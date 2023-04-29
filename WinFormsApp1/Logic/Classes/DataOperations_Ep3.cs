using System.Security.Cryptography.X509Certificates;
using WinFormsApp1.Logic.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic.Classes
{
    internal class DataOperations_Ep3 : IDataOperations_Ep3
    {
        public List<ModelNewPerson> InitiaiteModel(List<ModelOutput> list)
        {
            var model = new List<ModelNewPerson>();
            foreach (var item in list)
            {
                var newModel = new ModelNewPerson
                {
                    Number = item.Number,
                    X_REAL = item.X_REAL1,
                    X_BIN = item.X_BIN
                };
                model.Add(newModel);
            }
            return model;
        }
        public void DrawAndMarkParents(List<ModelNewPerson> list, double crossPorpability)
        {
            DataOperations_Ep2 obj = new DataOperations_Ep2();

            foreach (var item in list)
            {
                var r = obj.Draw_R();
                if (r <= crossPorpability)
                    item.X_Parents = item.X_BIN;
                else
                    item.X_Parents = "- - -";
            }
        }
        public void Crossing(List<ModelNewPerson> list)
        {
            var parentsList = GetParents(list);

            if (parentsList.Count() == 1)
                SingleCrossingMemberActions(parentsList);
            else
                MultipleCrossingMembersActions(parentsList);
        }
        private static void SingleCrossingMemberActions(List<ModelNewPerson> parentsList)
        {
            var parent = parentsList.Last();
            //jesli tylko jeden osobnik w populacji przetrwał to jest swoim dzieckiem i osobnikiem po krzyzowaniu
            parent.X_Children_Population = parent.X_Parents;
            parent.X_Crossed_Population = parent.X_Parents;
            parent.CutPosition = -1;
        }
        private void MultipleCrossingMembersActions(List<ModelNewPerson> parentsList)
        {
            for (int i = 0; i < parentsList.Count() - 1; i += 2)
            {
                var currenMember = parentsList.ElementAt(i);
                if (i + 1 < parentsList.Count())
                {
                    var member_1 = currenMember;
                    var member_2 = parentsList.ElementAt(i + 1);
                    CrossMembers(member_1, member_2);
                }
            }
            if (parentsList.Count() % 2 != 0)
            {
                var lastMember = parentsList.Last();
                var drewMember = parentsList.ElementAt(RngInt(0, parentsList.Count() - 1));
                lastMember.CutPosition = drewMember.CutPosition; 
                CrossOneMember(lastMember, drewMember);
            }
        }
        public void CrossMembers(ModelNewPerson model1, ModelNewPerson model2)
        {
            var cutPoint = DrawCutPosition(model1);
            var member1 = model1.X_BIN;
            var member2 = model2.X_BIN;

            var member1_1st = member1.Substring(0, cutPoint);
            var member1_2nd = member1.Substring(cutPoint);

            var member2_1st = member2.Substring(0, cutPoint);
            var member2_2nd = member2.Substring(cutPoint);

            var newChild1 = member1_1st + member2_2nd;
            var newChild2 = member2_1st + member1_2nd;

            model1.X_Children_Population = newChild1;
            model2.X_Children_Population = newChild2;            
            
            model1.X_Crossed_Population = newChild1;
            model2.X_Crossed_Population = newChild2;

            model1.CutPosition = model2.CutPosition = cutPoint;
        }
        public void CrossOneMember(ModelNewPerson modelToCross, ModelNewPerson modelToTake)
        {
            var cutPosition = modelToTake.CutPosition;
            var member1 = modelToCross.X_BIN;
            var member2 = modelToTake.X_BIN;

            var member1_1st = member1.Substring(0, cutPosition); // początek pierwszego
            var member2_2nd = member2.Substring(cutPosition);//końcówka zapożyczna

            modelToCross.X_Children_Population = member1_1st + member2_2nd;
            modelToCross.CutPosition = cutPosition;
            modelToCross.X_Crossed_Population = member1_1st + member2_2nd;
        }
        public List<ModelNewPerson> GetParents(List<ModelNewPerson> list)
        {
            var parents = new List<ModelNewPerson>();

            foreach (var item in list)
            {
                if (!item.X_Parents.Equals("- - -"))
                    parents.Add(item);
                else FillBlankParent(item);
            }
            return parents;
        }
        private void FillBlankParent(ModelNewPerson parent)
        {
            parent.X_Children_Population = "- - -";
            parent.CutPosition = -1;
            parent.X_Crossed_Population = parent.X_BIN;
        }
        public void Mutation(List<ModelNewPerson> list, double mutationPropability)
        {
            foreach (var item in list)
            {
                string mutatedMember = string.Empty;
                string mutationPositions = string.Empty;
                int iterator = 1;

                foreach (var c in item.X_Crossed_Population)
                {
                    if (RngDouble() < mutationPropability)
                    {
                        mutatedMember += SwapBit(c);
                        mutationPositions += $"{iterator} ";
                    }
                    else
                        mutatedMember += c;
                    iterator++;
                }
                item.MutationPositions = mutationPositions;
                item.X_Mutated_Population = mutatedMember;
            }
        }
        public void FillMutatedX_Real(List<ModelNewPerson> list, int a, int b, int l, double precision)
        {
            DataOperations_Ep1 lab1 = new DataOperations_Ep1();
            list.ForEach(x => x.X_REAL_Mutated_Population = lab1.IntToReal(lab1.BinToInt(x.X_Mutated_Population), a, b, l, precision));
        }
        public int DrawCutPosition(ModelNewPerson model)
        {
            var range = model.X_BIN.Length;
            Random rnd = new Random();
            return rnd.Next(2, range-1);
        }
        private int RngInt(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(a + 1, b);
        }
        private double RngDouble()
        {
            Random rnd = new Random();
            return rnd.NextDouble();
        }
        public char SwapBit(char bit) => bit == '0' ? '1' : '0';
        public void Function_F(List<ModelNewPerson> list)
        {
            DataOperations_Ep1 lab1 = new DataOperations_Ep1();
            list.ForEach(x => x.Function_F = lab1.Function_X(x.X_REAL_Mutated_Population));
        }
    }
}
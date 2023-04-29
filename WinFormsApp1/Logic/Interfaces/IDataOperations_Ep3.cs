using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic.Interfaces
{
    internal interface IDataOperations_Ep3
    {
        List<ModelNewPerson> InitiaiteModel(List<ModelOutput> list);
        void DrawAndMarkParents(List<ModelNewPerson> list, double crossPropability);
        void Crossing(List<ModelNewPerson> list);
        void CrossMembers(ModelNewPerson model1, ModelNewPerson model2);
        List<ModelNewPerson> GetParents(List<ModelNewPerson> list);
        void Mutation(List<ModelNewPerson> list, double mutationPropability);
        void FillMutatedX_Real(List<ModelNewPerson> list, int a, int b, int l, double precision);
        int DrawCutPosition(ModelNewPerson model);
        char SwapBit(char bit);
        void Function_F(List<ModelNewPerson> list);
    }
}

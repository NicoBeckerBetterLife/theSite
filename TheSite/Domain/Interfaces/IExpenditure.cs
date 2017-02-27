using Domain.Services;

namespace Domain.interfaces
{
    public interface IExpenditure
    {
        void CreateNewExpenditure(Expenditure expenditure);
        void UpdateExpenditure(Expenditure expenditure);
        void removeExpenditure();
    }
}
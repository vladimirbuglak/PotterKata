namespace PotterKata.BusinessLogic
{
    public interface IDiscountInformation
    {
        decimal Get(int countOfUniqueBookSeries);
    }
}

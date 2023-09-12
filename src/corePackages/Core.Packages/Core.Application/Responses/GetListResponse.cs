using Core.Persistance.Paging;

namespace Core.Application.Responses;

public class GetListResponse<T> : BasePageableModel
{
    private IList<T> items;


    public IList<T> Items
    {
        get => items ?? new List<T>();
        set => items = value;
    }
}

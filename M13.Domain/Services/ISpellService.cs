using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace M13.Domain.Services
{
    public interface ISpellService
    {
        Task<ICollection<string>> GetErrorsByPageAsync(string page, CancellationToken cancellationToken);
    }
}
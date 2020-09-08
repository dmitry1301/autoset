using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using M13.Domain.Models.Spells;

namespace M13.Domain.Providers
{
    public interface ISpellServiceProvider
    {
        Task<List<SpellErrorModel>> GetErrorsByTextAsync(string text, int maxCount, CancellationToken cancellationToken = default);
    }
}
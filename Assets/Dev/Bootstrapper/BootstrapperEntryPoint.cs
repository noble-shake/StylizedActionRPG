using Cysharp.Threading.Tasks;
using System.Threading;
using VContainer.Unity;

namespace RottenNoble.Cores
{
    public class BootstrapperEntryPoint : IAsyncStartable
    {
        private readonly string Tag = $"[{nameof(BootstrapperEntryPoint)}]";

        public BootstrapperEntryPoint(
                //AppSettingMangaer appSettingManager,

            )
        { 
        
        }


        public UniTask StartAsync(CancellationToken cancellation = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using VContainer.Unity;

using RottenNoble.Cores.Enum;

namespace RottenNoble.Cores
{
    public class AppSettingMangaer : IAppSettingManager, IInitializable, IDisposable, IAsyncStartable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void SwitchingAppSetting(ApplicationType value)
        {
            throw new NotImplementedException();
        }

        UniTask IAsyncStartable.StartAsync(CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
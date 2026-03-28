using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System;
using UnityEngine;

using RottenNoble.Cores.Enum;

namespace RottenNoble.Cores
{
    public interface IAppSettingManager 
    {
        void SwitchingAppSetting(ApplicationType value);
    }

    public interface IResourceManager
    {
        UniTask<T> LoadAsync<T>(string path, Action<string, float> onProgress = null) where T : UnityEngine.Object;
        UniTask<List<T>> LoadsAsync<T>(List<string> paths, Action<string, float> onProgress = null) where T : UnityEngine.Object;

        UniTask<T> CreateInstanceAsync<T>(string path, Transform parent) where T : UnityEngine.Object;
        UniTask<List<T>> CreateInstancesAsync<T>(List<string> paths, Transform parent) where T : UnityEngine.Object;

        UniTask<List<T>> LoadByLabelAsync<T>(string label, Action<string, float> onProgress = null) where T : UnityEngine.Object;

        void DeleteInstance(UnityEngine.Object instanceObject);
        void Dispose();
    }

    public interface IResourceFactory
    {
        void Init();
    }
}
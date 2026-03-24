using VContainer.Unity;
using UnityEngine;
using System;
using Cysharp.Threading.Tasks;
using System.Collections.Generic;


namespace RottenNoble.Cores
{
    public class ResourceManager : IInitializable, IResourceManager, IDisposable
    {
        private string Tag = $"{nameof(ResourceManager)}";
        private IResourceManager resourceProvider;
        private IResourceManager addressableProvider;

        public ResourceManager()
        { 
            //resourceManager = new IResourceManager();
        }

        public UniTask<T> CreateInstanceAsync<T>(string path, Transform parent) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public UniTask<List<T>> CreateInstancesAsync<T>(List<string> paths, Transform parent) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public void DeleteInstance(UnityEngine.Object instanceObject)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }

        public void Initialize()
        {

        }

        public UniTask<T> LoadAsync<T>(string path, Action<string, float> onProgress = null) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public UniTask<List<T>> LoadByLabelAsync<T>(string label, Action<string, float> onProgress = null) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public UniTask<List<T>> LoadsAsync<T>(List<string> paths, Action<string, float> onProgress = null) where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }
    }
}



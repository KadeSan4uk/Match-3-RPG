using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Project.Scripts.Bootstrap
{
    public class BootstrapController
    {
        private const string LobbySceneTag = "Lobby";
        
        private readonly BootstrapView _bootstrapView;

        public BootstrapController(BootstrapView bootstrapView)
        {
            _bootstrapView = bootstrapView;
            _bootstrapView.SetProgress(0);
        }

        public async Task StartAsync()
        {
            await Task.Delay(1000);

            _bootstrapView.SetProgress(10);
            
            await Task.Delay(1000);

            _bootstrapView.SetProgress(30);
            
            await Task.Delay(1000);

            _bootstrapView.SetProgress(60);
            
            await Task.Delay(1000);

            _bootstrapView.SetProgress(80);
            
            await Task.Delay(1000);
            
            _bootstrapView.SetProgress(80);
            
            await Task.Delay(1000);

            SceneManager.LoadSceneAsync(LobbySceneTag);
        }
    }
}

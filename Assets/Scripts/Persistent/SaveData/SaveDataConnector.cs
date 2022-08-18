using Agate.MVC.Base;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Persistent.SaveData
{
    public class SaveDataConnector : BaseConnector
    {
        private SaveDataController _saveData;
        protected override void Connect()
        {
            Subscribe<GameOverConfirmedMessage>(_saveData.SetLeaderboardData);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverConfirmedMessage>(_saveData.SetLeaderboardData);
        }
    }
}

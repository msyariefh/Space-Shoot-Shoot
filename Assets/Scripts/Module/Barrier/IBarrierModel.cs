using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Barrier
{
    public interface IBarrierModel : IBaseModel
    {
        public int[] Health { get; }
    }
}
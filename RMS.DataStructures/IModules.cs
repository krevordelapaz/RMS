using RMS.DataStructures.Admin;

namespace RMS.DataStructures
{
    public interface IModules
    {
        IAdmin AdminModule { get; }

        void Clear();
    }
}

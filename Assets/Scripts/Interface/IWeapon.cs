namespace EMSYS.FPS.Interface
{
    public interface IWeapon
    {

        //When Press Mouse 0
        void MainStart();
        void MainEnd();

        //When Press Mouse 1
        void SubStart();
        void SubEnd();
        //When Press R
        void ReloadStart();
        void ReloadEnd();
    }
}
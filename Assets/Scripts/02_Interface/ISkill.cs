namespace EMSYS.FPS.Interface
{
    public interface ISkill
    {
        void MainSkillStart();
        void MainSkillEnd();

        void SubSkillStart();
        void SubSkillEnd();

        void OverpowerStart();
        void OverpowerEnd();
    }
}
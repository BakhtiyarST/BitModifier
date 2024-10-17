namespace BitModifier_S2;
public interface IControllable
{
	bool IsOn {  get; }
	void On();

	void Off();
}
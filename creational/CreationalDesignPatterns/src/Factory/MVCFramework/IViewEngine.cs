namespace CreationalDesignPatterns.src.Factory.MVCFramework;

public interface IViewEngine
{
string Render(string fileName, Dictionary<string, object> data);
}

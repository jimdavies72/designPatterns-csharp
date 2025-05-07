namespace CreationalDesignPatterns.src.Singleton;

public class AppSettings
{
  private static AppSettings? _instance;
  private Dictionary<string, object> _settings = new Dictionary<string, object>();

  private AppSettings() { }

  public static AppSettings GetInstance()
  {
    if (_instance == null)
    {
      _instance = new AppSettings();
    }

    return _instance;
  }

  public object? Get(string key)
  {
    if (!_settings.ContainsKey(key))
    {
      return null;
    }
    return _settings[key];
  }

  public void Set(string key, object value)
  {
    _settings[key] = value;
  }
}

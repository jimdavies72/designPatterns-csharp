using System;

namespace structuralDesignPatterns.src.Proxy.NaiveExample;

public class RunProxyNaiveExample
{
  public static void RunProxyNaiveExampleCode()
  {
    var videoList = new VideoList();
    String[] videoIds = { "123", "abc", "hello" };

    foreach(var videoId in videoIds)
    {
      videoList.Add(new YouTubeVideo(videoId));
    }

    videoList.Watch("123");
  }
}

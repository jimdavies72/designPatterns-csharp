using System;

namespace structuralDesignPatterns.src.Proxy;

public class RunProxy
{
public static void RunProxyPattern()
{
    var videoList = new VideoList();
    String[] videoIds = { "123", "abc", "hello" };

    foreach (var videoId in videoIds)
    {
      videoList.Add(new YouTubeVideoProxy(videoId));
    }

    videoList.Watch("123");
  }
}

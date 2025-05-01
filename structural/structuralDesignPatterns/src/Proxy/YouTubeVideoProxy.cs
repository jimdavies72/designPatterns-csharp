using System;

namespace structuralDesignPatterns.src.Proxy;

public class YouTubeVideoProxy(string videoId) : IVideo
{
  private string _videoId = videoId;
  private YouTubeVideo? _youTubeVideo;

  public string GetVideoId()
  {
    return _videoId;
  }

  public void Render()
  {
    if(_youTubeVideo == null)
    {
      _youTubeVideo = new YouTubeVideo(_videoId);
    }

    _youTubeVideo.Render();
  }
}

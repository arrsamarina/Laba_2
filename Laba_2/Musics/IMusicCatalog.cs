﻿using Laba_2;

namespace Laba_2.Musics;

public interface IMusicCatalog
{
    List<Music> listMusic();
    bool seachMusic(string name);
    void addMusic(Music music);
    void deleteMusic(string name);
}
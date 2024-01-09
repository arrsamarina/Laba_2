using Laba_2;
using Xunit;

namespace Laba_2.Test;

public class CalculateTests
{
    [Fact]
    public void FunctionList_ShouldBeZeroElement()
    {
        var musics = new MusicCatalog();

        Assert.Equal(musics.listMusic().Count, 0);
    }

    [Theory]
    [InlineData("author1", "composition1")]
    [InlineData("author2", "composition2")]
    public void FunctionList_ShouleBeZeroElement_ReturnFalse(string author, string composition)
    {
        var musics = new MusicCatalog();
        musics.addMusic(new Music(author, composition));

        Assert.False(musics.listMusic().Count() == 0);
    }

    [Theory]
    [InlineData("author1", "composition1", "com")]
    [InlineData("abc", "123", "123")]
    public void FunctionSearch_ShouldBeReturnTrue(string author, string composition, string key)
    {
        var musics = new MusicCatalog();
        musics.addMusic(new Music(author, composition));

        Assert.True(musics.seachMusic(key));
    }

    [Theory]
    [InlineData("author1", "composition1", "auth")]
    [InlineData("abc", "123", "author")]
    public void FunctionSearch_ShouldBeReturnFalse(string author, string composition, string key)
    {
        var musics = new MusicCatalog();
        musics.addMusic(new Music(author, composition));

        Assert.False(musics.seachMusic(key));
    }


    [Fact]
    public void FunctionAdd_ShouldAddNewMusic()
    {
        var musics = new MusicCatalog();
        Assert.Equal(musics.listMusic().Count(), 0);

        musics.addMusic(new Music("author1", "composition1"));
        Assert.Equal(musics.listMusic().Count(), 1);
    }


    [Theory]
    [InlineData("author1", "composition1", "author1 - composition1")]
    [InlineData("abc", "123", "abc - 123")]
    public void FunctionDel_ShouldBeDeleteMusic(string author, string composition, string fullname)
    {
        var musics = new MusicCatalog();
        musics.addMusic(new Music(author, composition));
        Assert.Equal(musics.listMusic().Count(), 1);

        musics.deleteMusic(fullname);
        Assert.Equal(musics.listMusic().Count(), 0);
    }

    [Theory]
    [InlineData("author1", "composition1", "author - composition")]
    [InlineData("abc", "123", "123")]
    public void FunctionDel_ShouldBeDeleteMusic_ReturnFalse(string author, string composition, string fullname)
    {
        var musics = new MusicCatalog();
        musics.addMusic(new Music(author, composition));
        Assert.Equal(musics.listMusic().Count(), 1);

        musics.deleteMusic(fullname);
        Assert.False(musics.listMusic().Count() == 0);
    }


}
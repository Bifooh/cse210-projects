public class Book
{

    private  List<Scripture> _book = new List<Scripture>()
    {
        new Scripture(
            new Reference("1 Nephi", "3", 7, 7), 
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ),

        new Scripture(
            new Reference("Amos", "3", 7, 7), 
            "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets."
        ),

        new Scripture(
            new Reference("John", "3", 5, 5), 
            "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."
        )
    };



    public Scripture GetScripture()
    {
        Random _randomObject = Random.Shared;
        int _randomIndex = _randomObject.Next(_book.Count);

        return _book[_randomIndex];
    }

    
}
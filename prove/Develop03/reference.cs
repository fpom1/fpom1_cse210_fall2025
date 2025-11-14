public class Reference
{
    private string _reference;
    private string _book;
    private string _chapter;
    private string _verses;
    public Reference()
    {
        _book = "";
        _chapter = "";
        _verses = "";
    }
    public Reference(string input)
    {
        _reference = input;
        _book = GetBook();
        _chapter = GetChapter();
        _verses = GetVerses();
    }
    private string GetBook()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        return wordList[0];
    }
    private string GetChapter()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        List<string> numbers = wordList[1].Split(":").ToList();
        return numbers[0];
    }
    private string GetVerses()
    {
        List<string> wordList = _reference.Split(" ").ToList();
        List<string> numbers = wordList[1].Split(":").ToList();
        return numbers[1];
    }
    public string ReReference()
    {        
        List<string> numbs = [_chapter,_verses];
        string numbers = string.Join(":", numbs);
        List<string> full = [_book,numbers];
        string reRef = string.Join(" ", full);
        return reRef;
    }
}
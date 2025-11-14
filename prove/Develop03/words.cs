public class Words
{
    private string _scripture;
    private List<string> _words;

    public Words()
    {
        _scripture = "";
        _words = new List<string>();
    }
    public Words(string scrpiture)
    {
        _scripture = scrpiture;
        _words = StringToList();
    }
    public List<string> StringToList()
    {
        List<string> wordList = _scripture.Split(" ").ToList();
        return wordList;
    }
}
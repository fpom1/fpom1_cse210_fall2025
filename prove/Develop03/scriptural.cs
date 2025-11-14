public class Scriptural
{
    private List<string> _words;
    private List<int> _index;
    private List<int> _checker;
    private int _difficulty;

    public Scriptural()
    {
        _words = new List<string>();
        _index = new List<int>();
        _checker = new List<int>();
    }
    public Scriptural(List<string> input, int difficulty)
    {
        _words = input;
        _index = GetIndices();
        _checker = _index;
        _checker = ModifyIndices();
        _difficulty = difficulty;
    }

        private List<int> GetIndices()
    {
        List<string> wordList = _words;
        List<int> indices = Enumerable.Range(0, wordList.Count).ToList();
        return indices;
    }

        public List<int> ModifyIndices()
    {
        Random random = new Random();
        int removal = _difficulty;
        while (removal != 0)
        {
            if (_checker.Count > 0)
            {
                int randomIndex = random.Next(0, _checker.Count);
                removal--;
                _checker.RemoveAt(randomIndex);
            }
            else
            {
                removal = 0;
            }
        }
        return _checker;
    }

    public string ModifedVerse()
    {
        List<string> modifiedList = [];
        List<string> words = _words;

        foreach (var item in words.Select((value, i) => new { i, value }))
        {
            var index = item.i;
            if (_checker.Contains(index))
            {
                modifiedList.Add(words[index]);
            }
            else
            {
                modifiedList.Add("____");
            }
        }

        string modifedVerse = string.Join(" ", modifiedList);
        return modifedVerse;
    }
}
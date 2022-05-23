using CommunityToolkit.Mvvm.ComponentModel;

namespace CoverageIssue;

public  class ViewModel
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}

public partial class ViewModelUsesObservableProperty : ObservableObject
{
    [ObservableProperty]
    private string _test = "hi";
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}

public partial class ViewModelInheritsValidator : ObservableValidator
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}


namespace TabbedPageScrollViewIssue;

public class MyTabbedPage : TabbedPage
{
	public MyTabbedPage()
	{
		Children.Add(new MyChildPage());
	}
}
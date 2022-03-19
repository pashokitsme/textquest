namespace TextQuest.Editor.ViewBehaviour;

public static class SidebarButton
{
    public static void OnMouseEnter(Label label)
    {
        label.BackColor = Color.Gray;
    }

    public static void OnMouseLeave(Label label)
    {
        label.BackColor = Color.Transparent;
    }
}
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

    public static void AddEffects(Label label)
    {
        label.MouseEnter += (_, _) => OnMouseEnter(label);
        label.MouseLeave += (_, _) => OnMouseLeave(label);
    }
}
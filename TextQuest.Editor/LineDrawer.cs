namespace TextQuest.Editor;

public class LineDrawer
{
    private readonly Control _parent;
    private readonly Pen _pen;
    private readonly HashSet<Line> _lines = new();
    private bool _shouldDraw = false;

    public LineDrawer(Control parent, Pen pen)
    {
        _parent = parent;
        _pen = pen;
        _parent.Paint += OnPaint;
    }

    public void Add(Line line) => _lines.Add(line);

    public void ScheduleDraw() => _shouldDraw = true;

    private void OnPaint(object sender, PaintEventArgs paint)
    {
        if (_shouldDraw == false)
            return;

        _shouldDraw = false;

        foreach (var line in _lines)
        {
            paint.Graphics.DrawLine(_pen, line.Start, line.End);
            Console.WriteLine($"Drawed {line.Start} {line.End}");
        }

        _lines.Clear();
    }
}

public struct Line
{
    public Point Start;
    public Point End;

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }
}

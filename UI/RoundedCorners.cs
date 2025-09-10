using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Student_Information_System.UI
{
    public class SPanel : Panel
    {
        private Color _backgroundColor = Color.White;
        private Color _borderColor = Color.White;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The background fill color.")]
        public Color BackgroundFillColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                Invalidate(); // Trigger repaint
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The border color.")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate(); // Trigger repaint
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 10;
            int outerX = 10, outerY = 10;
            int outerWidth = this.Width - 20;
            int outerHeight = this.Height - 20;

            int innerX = 12, innerY = 12;
            int innerWidth = this.Width - 24;
            int innerHeight = this.Height - 24;

            using (SolidBrush fillBrush = new SolidBrush(BackgroundFillColor))
            using (Pen borderPen = new Pen(BorderColor))
            {
                // Outer rounded background
                g.FillRoundedRectangle(fillBrush, outerX, outerY, outerWidth, outerHeight, radius);

                // Inner bottom half only (remove redundant full fill)
                g.FillRoundedRectangle(fillBrush, innerX, innerY + (innerHeight / 2), innerWidth, innerHeight / 2, radius);

                // Inner border
                g.DrawRoundedRectangle(borderPen, innerX, innerY, innerWidth, innerHeight, radius);
            }
        }
    }
}



static class GraphicsExtension
{
    private static GraphicsPath GenerateRoundedRectangle(
        this Graphics graphics,
        RectangleF rectangle,
        float radius)
    {
        float diameter;
        GraphicsPath path = new GraphicsPath();
        if (radius <= 0.0F)
        {
            path.AddRectangle(rectangle);
            path.CloseFigure();
            return path;
        }
        else
        {
            if (radius >= (Math.Min(rectangle.Width, rectangle.Height)) / 2.0)
                return graphics.GenerateCapsule(rectangle);
            diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rectangle.Location, sizeF);
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
        }
        return path;
    }
    private static GraphicsPath GenerateCapsule(
        this Graphics graphics,
        RectangleF baseRect)
    {
        float diameter;
        RectangleF arc;
        GraphicsPath path = new GraphicsPath();
        try
        {
            if (baseRect.Width > baseRect.Height)
            {
                diameter = baseRect.Height;
                SizeF sizeF = new SizeF(diameter, diameter);
                arc = new RectangleF(baseRect.Location, sizeF);
                path.AddArc(arc, 90, 180);
                arc.X = baseRect.Right - diameter;
                path.AddArc(arc, 270, 180);
            }
            else if (baseRect.Width < baseRect.Height)
            {
                diameter = baseRect.Width;
                SizeF sizeF = new SizeF(diameter, diameter);
                arc = new RectangleF(baseRect.Location, sizeF);
                path.AddArc(arc, 180, 180);
                arc.Y = baseRect.Bottom - diameter;
                path.AddArc(arc, 0, 180);
            }
            else path.AddEllipse(baseRect);
        }
        catch { path.AddEllipse(baseRect); }
        finally { path.CloseFigure(); }
        return path;
    }

    /// <summary>
    /// Draws a rounded rectangle specified by a pair of coordinates, a width, a height and the radius 
    /// for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Pen that determines the color, width and style of the rectangle.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="width">Width of the rectangle to draw.</param>
    /// <param name="height">Height of the rectangle to draw.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void DrawRoundedRectangle(
        this Graphics graphics,
        Pen pen,
        float x,
        float y,
        float width,
        float height,
        float radius)
    {
        RectangleF rectangle = new RectangleF(x, y, width, height);
        GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
        SmoothingMode old = graphics.SmoothingMode;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.DrawPath(pen, path);
        graphics.SmoothingMode = old;
    }

    /// <summary>
    /// Draws a rounded rectangle specified by a pair of coordinates, a width, a height and the radius 
    /// for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Pen that determines the color, width and style of the rectangle.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="width">Width of the rectangle to draw.</param>
    /// <param name="height">Height of the rectangle to draw.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void DrawRoundedRectangle(
        this Graphics graphics,
        Pen pen,
        int x,
        int y,
        int width,
        int height,
        int radius)
    {
        graphics.DrawRoundedRectangle(
            pen,
            Convert.ToSingle(x),
            Convert.ToSingle(y),
            Convert.ToSingle(width),
            Convert.ToSingle(height),
            Convert.ToSingle(radius));
    }

    /// <summary>
    /// Fills the interior of a rounded rectangle specified by a pair of coordinates, a width, a height
    /// and the radius for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Brush that determines the characteristics of the fill.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="width">Width of the rectangle to fill.</param>
    /// <param name="height">Height of the rectangle to fill.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void FillRoundedRectangle(
        this Graphics graphics,
        Brush brush,
        float x,
        float y,
        float width,
        float height,
        float radius)
    {
        RectangleF rectangle = new RectangleF(x, y, width, height);
        GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius);
        SmoothingMode old = graphics.SmoothingMode;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.FillPath(brush, path);
        graphics.SmoothingMode = old;
    }

    /// <summary>
    /// Fills the interior of a rounded rectangle specified by a pair of coordinates, a width, a height
    /// and the radius for the arcs that make the rounded edges.
    /// </summary>
    /// <param name="brush">System.Drawing.Brush that determines the characteristics of the fill.</param>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="width">Width of the rectangle to fill.</param>
    /// <param name="height">Height of the rectangle to fill.</param>
    /// <param name="radius">The radius of the arc used for the rounded edges.</param>

    public static void FillRoundedRectangle(
        this Graphics graphics,
        Brush brush,
        int x,
        int y,
        int width,
        int height,
        int radius)
    {
        graphics.FillRoundedRectangle(
            brush,
            Convert.ToSingle(x),
            Convert.ToSingle(y),
            Convert.ToSingle(width),
            Convert.ToSingle(height),
            Convert.ToSingle(radius));
    }
}
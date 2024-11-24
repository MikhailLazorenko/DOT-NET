using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

[Serializable]
public class Configuration
{
    public SerializableColor MainFormBackColor { get; set; }
    public SerializableFont SubmitButtonFont { get; set; }
    public SerializableFont GroupBoxFont { get; set; }
    public SerializableColor OpinionTextBoxBackColor { get; set; }
    public SerializableFont InterestsCheckBoxFont { get; set; }
    public Configuration() { }

    public Configuration(Form1 form)
    {
        MainFormBackColor = new SerializableColor(form.BackColor);
        SubmitButtonFont = new SerializableFont(form.submitButton.Font);
        GroupBoxFont = new SerializableFont(form.personalInfoGroupBox.Font);
        OpinionTextBoxBackColor = new SerializableColor(form.opinionTextBox.BackColor);
        InterestsCheckBoxFont = new SerializableFont(form.computersCheckBox.Font);
    }

    public void ApplyConfiguration(Form1 form)
    {
        form.BackColor = MainFormBackColor.ToColor();
        form.submitButton.Font = SubmitButtonFont.ToFont();
        form.personalInfoGroupBox.Font = GroupBoxFont.ToFont();
        form.opinionGroupBox.Font = GroupBoxFont.ToFont();
        form.opinionTextBox.BackColor = OpinionTextBoxBackColor.ToColor();

        foreach (Control control in form.personalInfoGroupBox.Controls)
        {
            if (control is CheckBox checkBox)
            {
                checkBox.Font = InterestsCheckBoxFont.ToFont();
            }
        }
    }
}

[Serializable]
public class SerializableFont
{
    public string FontFamilyName { get; set; }
    public float Size { get; set; }
    public FontStyle Style { get; set; }

    public SerializableFont() { }

    public SerializableFont(Font font)
    {
        FontFamilyName = font.FontFamily.Name;
        Size = font.Size;
        Style = font.Style;
    }

    public Font ToFont()
    {
        return new Font(FontFamilyName, Size, Style);
    }
}

[Serializable]
public class SerializableColor
{
    public int Argb { get; set; }

    public SerializableColor() { }

    public SerializableColor(Color color)
    {
        Argb = color.ToArgb();
    }

    public Color ToColor()
    {
        return Color.FromArgb(Argb);
    }
}

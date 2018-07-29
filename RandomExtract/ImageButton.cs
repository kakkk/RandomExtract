using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RandomExtract
{
	public class ImageButton : PictureBox, IButtonControl
	{
		private const int WM_KEYDOWN = 256;

		private const int WM_KEYUP = 257;

		private DialogResult _DialogResult;

		private Image _HoverImage;

		private Image _DownImage;

		private Image _NormalImage;

		private bool _hover;

		private bool _down;

		private bool _isDefault;

		private bool _holdingSpace;

		private ToolTip _toolTip = new ToolTip();

		public DialogResult DialogResult
		{
			get
			{
				return this._DialogResult;
			}
			set
			{
				if (Enum.IsDefined(typeof(DialogResult), value))
				{
					this._DialogResult = value;
				}
			}
		}

		[Category("Appearance"), Description("当按钮被悬停时显示的图像")]
		public Image HoverImage
		{
			get
			{
				return this._HoverImage;
			}
			set
			{
				this._HoverImage = value;
				if (this._hover)
				{
					this.Image = value;
				}
			}
		}

		[Category("Appearance"), Description("当按钮被按下时显示的图像")]
		public Image DownImage
		{
			get
			{
				return this._DownImage;
			}
			set
			{
				this._DownImage = value;
				if (this._down)
				{
					this.Image = value;
				}
			}
		}

		[Category("Appearance"), Description("按钮默认显示的图像")]
		public Image NormalImage
		{
			get
			{
				return this._NormalImage;
			}
			set
			{
				this._NormalImage = value;
				if (!this._hover && !this._down)
				{
					this.Image = value;
				}
			}
		}

		[Browsable(true), Category("Appearance"), Description("与控件相关联的文本"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		[Browsable(true), Category("Appearance"), Description("用于在控件中显示文本的字体"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
			}
		}

		[Description("当鼠标放在控件可见处的提示文本")]
		public string ToolTipText
		{
			get;
			set;
		}

		[Description("控制ImageButton如何处理图像放置和控制大小")]
		public new PictureBoxSizeMode SizeMode
		{
			get
			{
				return base.SizeMode;
			}
			set
			{
				base.SizeMode = value;
			}
		}

		[Description("控制ImageButton应该有什么类型的边框")]
		public new BorderStyle BorderStyle
		{
			get
			{
				return base.BorderStyle;
			}
			set
			{
				base.BorderStyle = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Image Image
		{
			get
			{
				return base.Image;
			}
			set
			{
				base.Image = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new ImageLayout BackgroundImageLayout
		{
			get
			{
				return base.BackgroundImageLayout;
			}
			set
			{
				base.BackgroundImageLayout = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Image BackgroundImage
		{
			get
			{
				return base.BackgroundImage;
			}
			set
			{
				base.BackgroundImage = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new string ImageLocation
		{
			get
			{
				return base.ImageLocation;
			}
			set
			{
				base.ImageLocation = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Image ErrorImage
		{
			get
			{
				return base.ErrorImage;
			}
			set
			{
				base.ErrorImage = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new Image InitialImage
		{
			get
			{
				return base.InitialImage;
			}
			set
			{
				base.InitialImage = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new bool WaitOnLoad
		{
			get
			{
				return base.WaitOnLoad;
			}
			set
			{
				base.WaitOnLoad = value;
			}
		}

		public ImageButton()
		{
			this.BackColor = Color.Transparent;
			base.Size = new Size(75, 23);
		}

		public void NotifyDefault(bool value)
		{
			if (this._isDefault != value)
			{
				this._isDefault = value;
			}
		}

		public void PerformClick()
		{
			base.OnClick(EventArgs.Empty);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			if (this.ToolTipText != string.Empty)
			{
				this.HideToolTip();
				this.ShowTooTip(this.ToolTipText);
			}
			base.OnMouseEnter(e);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			this._hover = true;
			if (this._down)
			{
				if (this._DownImage != null && this.Image != this._DownImage)
				{
					this.Image = this._DownImage;
				}
			}
			else if (this._HoverImage != null)
			{
				this.Image = this._HoverImage;
			}
			else
			{
				this.Image = this._NormalImage;
			}
			base.OnMouseMove(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			this._hover = false;
			this.Image = this._NormalImage;
			base.OnMouseLeave(e);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.Focus();
			this.OnMouseUp(null);
			this._down = true;
			if (this._DownImage != null)
			{
				this.Image = this._DownImage;
			}
			base.OnMouseDown(e);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			this._down = false;
			if (this._hover)
			{
				if (this._HoverImage != null)
				{
					this.Image = this._HoverImage;
				}
			}
			else
			{
				this.Image = this._NormalImage;
			}
			base.OnMouseUp(e);
		}

		public override bool PreProcessMessage(ref Message msg)
		{
			if (msg.Msg == 257)
			{
				if (this._holdingSpace)
				{
					if ((int)msg.WParam == 32)
					{
						this.OnMouseUp(null);
						this.PerformClick();
					}
					else if ((int)msg.WParam == 27 || (int)msg.WParam == 9)
					{
						this._holdingSpace = false;
						this.OnMouseUp(null);
					}
				}
				return true;
			}
			if (msg.Msg == 256)
			{
				if ((int)msg.WParam == 32)
				{
					this._holdingSpace = true;
					this.OnMouseDown(null);
				}
				else if ((int)msg.WParam == 13)
				{
					this.PerformClick();
				}
				return true;
			}
			return base.PreProcessMessage(ref msg);
		}

		protected override void OnLostFocus(EventArgs e)
		{
			this._holdingSpace = false;
			this.OnMouseUp(null);
			base.OnLostFocus(e);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			if (!string.IsNullOrEmpty(this.Text) && pe != null && base.Font != null)
			{
				SizeF sizeF = pe.Graphics.MeasureString(base.Text, base.Font);
				PointF point;
				if (base.Image != null)
				{
					point = new PointF((float)(base.Image.Width / 2) - sizeF.Width / 2f, (float)(base.Image.Height / 2) - sizeF.Height / 2f);
				}
				else
				{
					point = new PointF((float)(base.Width / 2) - sizeF.Width / 2f, (float)(base.Height / 2) - sizeF.Height / 2f);
				}
				using (SolidBrush solidBrush = new SolidBrush(base.ForeColor))
				{
					pe.Graphics.DrawString(base.Text, base.Font, solidBrush, point);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this._toolTip != null)
			{
				this._toolTip.Dispose();
			}
			this._toolTip = null;
			base.Dispose(disposing);
		}

		protected override void OnTextChanged(EventArgs e)
		{
			this.Refresh();
			base.OnTextChanged(e);
		}

		private void ShowTooTip(string toolTipText)
		{
			this._toolTip.Active = true;
			this._toolTip.SetToolTip(this, toolTipText);
		}

		private void HideToolTip()
		{
			this._toolTip.Active = false;
		}
	}
}

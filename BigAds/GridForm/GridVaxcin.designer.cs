
namespace DataUseVaccine.Frm
{
    partial class GridVaxcin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridVaxcin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vx_ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_nsx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_lo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_hsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx_slNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vx__slXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.vx_ngayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 56);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(988, 473);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Thông tin Vaccine";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(984, 448);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vx_ma,
            this.vx_ten,
            this.vx_nsx,
            this.vx_location,
            this.vx_lo,
            this.vx_ngayNhap,
            this.vx_hsd,
            this.vx_slNhap,
            this.vx__slXuat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // vx_ma
            // 
            this.vx_ma.AppearanceHeader.Options.UseTextOptions = true;
            this.vx_ma.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vx_ma.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vx_ma.Caption = "Mã ‎Vaccine";
            this.vx_ma.FieldName = "vx_ma";
            this.vx_ma.Name = "vx_ma";
            this.vx_ma.OptionsColumn.ReadOnly = true;
            this.vx_ma.Visible = true;
            this.vx_ma.VisibleIndex = 1;
            this.vx_ma.Width = 150;
            // 
            // vx_ten
            // 
            this.vx_ten.AppearanceHeader.Options.UseTextOptions = true;
            this.vx_ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vx_ten.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vx_ten.Caption = "Tên ‎Vaccine";
            this.vx_ten.FieldName = "vx_ten";
            this.vx_ten.Name = "vx_ten";
            this.vx_ten.OptionsColumn.ReadOnly = true;
            this.vx_ten.Visible = true;
            this.vx_ten.VisibleIndex = 2;
            this.vx_ten.Width = 250;
            // 
            // vx_nsx
            // 
            this.vx_nsx.AppearanceHeader.Options.UseTextOptions = true;
            this.vx_nsx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vx_nsx.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vx_nsx.Caption = "Nhà sx";
            this.vx_nsx.FieldName = "vx_nsx";
            this.vx_nsx.Name = "vx_nsx";
            this.vx_nsx.OptionsColumn.ReadOnly = true;
            this.vx_nsx.Visible = true;
            this.vx_nsx.VisibleIndex = 3;
            this.vx_nsx.Width = 250;
            // 
            // vx_location
            // 
            this.vx_location.Caption = "Nước sx";
            this.vx_location.FieldName = "vx_location";
            this.vx_location.Name = "vx_location";
            this.vx_location.OptionsColumn.ReadOnly = true;
            this.vx_location.Visible = true;
            this.vx_location.VisibleIndex = 4;
            this.vx_location.Width = 250;
            // 
            // vx_lo
            // 
            this.vx_lo.Caption = "Lô";
            this.vx_lo.FieldName = "vx_lo";
            this.vx_lo.Name = "vx_lo";
            this.vx_lo.OptionsColumn.ReadOnly = true;
            this.vx_lo.Visible = true;
            this.vx_lo.VisibleIndex = 5;
            this.vx_lo.Width = 150;
            // 
            // vx_hsd
            // 
            this.vx_hsd.Caption = "Hạn SD";
            this.vx_hsd.DisplayFormat.FormatString = "dd - MM - yyyy";
            this.vx_hsd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.vx_hsd.FieldName = "vx_hsd";
            this.vx_hsd.Name = "vx_hsd";
            this.vx_hsd.OptionsColumn.ReadOnly = true;
            this.vx_hsd.Visible = true;
            this.vx_hsd.VisibleIndex = 7;
            this.vx_hsd.Width = 150;
            // 
            // vx_slNhap
            // 
            this.vx_slNhap.Caption = "SL nhập";
            this.vx_slNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.vx_slNhap.FieldName = "vx_slNhap";
            this.vx_slNhap.Name = "vx_slNhap";
            this.vx_slNhap.OptionsColumn.ReadOnly = true;
            this.vx_slNhap.Visible = true;
            this.vx_slNhap.VisibleIndex = 8;
            this.vx_slNhap.Width = 150;
            // 
            // vx__slXuat
            // 
            this.vx__slXuat.Caption = "SL xuất";
            this.vx__slXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.vx__slXuat.FieldName = "vx__slXuat";
            this.vx__slXuat.Name = "vx__slXuat";
            this.vx__slXuat.OptionsColumn.ReadOnly = true;
            this.vx__slXuat.Visible = true;
            this.vx__slXuat.VisibleIndex = 9;
            this.vx__slXuat.Width = 150;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(988, 56);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Chức năng";
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "    Xóa";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges1;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.IdleBorderRadius = 10;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.IdleIconLeftImage")));
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(261, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 10;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnDelete.onHoverState.BorderRadius = 10;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.OnIdleState.BorderRadius = 10;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.OnIdleState.IconLeftImage")));
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDelete.OnPressedState.BorderRadius = 10;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AllowAnimations = true;
            this.btnEdit.AllowMouseEffects = true;
            this.btnEdit.AllowToggling = false;
            this.btnEdit.AnimationSpeed = 200;
            this.btnEdit.AutoGenerateColors = false;
            this.btnEdit.AutoRoundBorders = false;
            this.btnEdit.AutoSizeLeftIcon = true;
            this.btnEdit.AutoSizeRightIcon = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.ButtonText = "    Sửa";
            this.btnEdit.ButtonTextMarginLeft = 0;
            this.btnEdit.ColorContrastOnClick = 45;
            this.btnEdit.ColorContrastOnHover = 45;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEdit.CustomizableEdges = borderEdges2;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEdit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEdit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEdit.IconMarginLeft = 11;
            this.btnEdit.IconPadding = 10;
            this.btnEdit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEdit.IconSize = 25;
            this.btnEdit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.IdleBorderRadius = 10;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.IdleIconLeftImage")));
            this.btnEdit.IdleIconRightImage = null;
            this.btnEdit.IndicateFocus = false;
            this.btnEdit.Location = new System.Drawing.Point(139, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEdit.OnDisabledState.BorderRadius = 10;
            this.btnEdit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnDisabledState.BorderThickness = 1;
            this.btnEdit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEdit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEdit.OnDisabledState.IconLeftImage = null;
            this.btnEdit.OnDisabledState.IconRightImage = null;
            this.btnEdit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.btnEdit.onHoverState.BorderRadius = 10;
            this.btnEdit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.onHoverState.BorderThickness = 1;
            this.btnEdit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.btnEdit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.onHoverState.IconLeftImage = null;
            this.btnEdit.onHoverState.IconRightImage = null;
            this.btnEdit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.OnIdleState.BorderRadius = 10;
            this.btnEdit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnIdleState.BorderThickness = 1;
            this.btnEdit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEdit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.OnIdleState.IconLeftImage")));
            this.btnEdit.OnIdleState.IconRightImage = null;
            this.btnEdit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEdit.OnPressedState.BorderRadius = 10;
            this.btnEdit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.OnPressedState.BorderThickness = 1;
            this.btnEdit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEdit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEdit.OnPressedState.IconLeftImage = null;
            this.btnEdit.OnPressedState.IconRightImage = null;
            this.btnEdit.Size = new System.Drawing.Size(96, 39);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.TextMarginLeft = 0;
            this.btnEdit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEdit.UseDefaultRadiusAndThickness = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "     Thêm";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges3;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.IdleBorderRadius = 10;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.IdleIconLeftImage")));
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(27, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 10;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdd.onHoverState.BorderRadius = 10;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.OnIdleState.BorderRadius = 10;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.OnIdleState.IconLeftImage")));
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 10;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(93, 39);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vx_ngayNhap
            // 
            this.vx_ngayNhap.Caption = "Ngày nhập";
            this.vx_ngayNhap.DisplayFormat.FormatString = "dd - MM - yyyy";
            this.vx_ngayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.vx_ngayNhap.FieldName = "vx_ngayNhap";
            this.vx_ngayNhap.Name = "vx_ngayNhap";
            this.vx_ngayNhap.Visible = true;
            this.vx_ngayNhap.VisibleIndex = 6;
            this.vx_ngayNhap.Width = 150;
            // 
            // GridVaxcin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "GridVaxcin";
            this.Size = new System.Drawing.Size(988, 529);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn vx_ma;
        private DevExpress.XtraGrid.Columns.GridColumn vx_ten;
        private DevExpress.XtraGrid.Columns.GridColumn vx_nsx;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEdit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn vx_location;
        private DevExpress.XtraGrid.Columns.GridColumn vx_lo;
        private DevExpress.XtraGrid.Columns.GridColumn vx_hsd;
        private DevExpress.XtraGrid.Columns.GridColumn vx_slNhap;
        private DevExpress.XtraGrid.Columns.GridColumn vx__slXuat;
        private DevExpress.XtraGrid.Columns.GridColumn vx_ngayNhap;
    }
}

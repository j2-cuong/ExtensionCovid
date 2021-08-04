
namespace BigAds.Frm
{
    partial class GridDtuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridDtuong));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DTuong_ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_nsinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_GTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_DVCtac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_BHYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_Tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_TinhCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_Quan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_QuanCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_Xa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_XaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DTuong_DCCtiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isTimeAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.groupControl2.Text = "Thông tin đối tượng";
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
            this.DTuong_ma,
            this.DTuong_ten,
            this.DTuong_nsinh,
            this.DTuong_GTinh,
            this.DTuong_DVCtac,
            this.DTuong_SDT,
            this.DTuong_CCCD,
            this.DTuong_BHYT,
            this.NhomDT,
            this.DTuong_Tinh,
            this.DTuong_TinhCode,
            this.DTuong_Quan,
            this.DTuong_QuanCode,
            this.DTuong_Xa,
            this.DTuong_XaCode,
            this.DTuong_DCCtiet,
            this.isTimeAdd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // DTuong_ma
            // 
            this.DTuong_ma.Caption = "Mã ĐT";
            this.DTuong_ma.FieldName = "DTuong_ma";
            this.DTuong_ma.Name = "DTuong_ma";
            this.DTuong_ma.OptionsColumn.ReadOnly = true;
            this.DTuong_ma.Visible = true;
            this.DTuong_ma.VisibleIndex = 1;
            this.DTuong_ma.Width = 200;
            // 
            // DTuong_ten
            // 
            this.DTuong_ten.Caption = "Tên ĐT";
            this.DTuong_ten.FieldName = "DTuong_ten";
            this.DTuong_ten.Name = "DTuong_ten";
            this.DTuong_ten.OptionsColumn.ReadOnly = true;
            this.DTuong_ten.Visible = true;
            this.DTuong_ten.VisibleIndex = 2;
            this.DTuong_ten.Width = 350;
            // 
            // DTuong_nsinh
            // 
            this.DTuong_nsinh.Caption = "Năm sinh";
            this.DTuong_nsinh.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.DTuong_nsinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DTuong_nsinh.FieldName = "DTuong_nsinh";
            this.DTuong_nsinh.Name = "DTuong_nsinh";
            this.DTuong_nsinh.OptionsColumn.ReadOnly = true;
            this.DTuong_nsinh.Visible = true;
            this.DTuong_nsinh.VisibleIndex = 3;
            this.DTuong_nsinh.Width = 100;
            // 
            // DTuong_GTinh
            // 
            this.DTuong_GTinh.Caption = "Giới tính";
            this.DTuong_GTinh.FieldName = "DTuong_GTinh";
            this.DTuong_GTinh.Name = "DTuong_GTinh";
            this.DTuong_GTinh.OptionsColumn.ReadOnly = true;
            this.DTuong_GTinh.Visible = true;
            this.DTuong_GTinh.VisibleIndex = 4;
            this.DTuong_GTinh.Width = 100;
            // 
            // DTuong_DVCtac
            // 
            this.DTuong_DVCtac.Caption = "Đơn vị C/tác";
            this.DTuong_DVCtac.FieldName = "DTuong_DVCtac";
            this.DTuong_DVCtac.Name = "DTuong_DVCtac";
            this.DTuong_DVCtac.OptionsColumn.ReadOnly = true;
            this.DTuong_DVCtac.Visible = true;
            this.DTuong_DVCtac.VisibleIndex = 5;
            this.DTuong_DVCtac.Width = 350;
            // 
            // DTuong_SDT
            // 
            this.DTuong_SDT.Caption = "Số ĐT";
            this.DTuong_SDT.FieldName = "DTuong_SDT";
            this.DTuong_SDT.Name = "DTuong_SDT";
            this.DTuong_SDT.OptionsColumn.ReadOnly = true;
            this.DTuong_SDT.Visible = true;
            this.DTuong_SDT.VisibleIndex = 6;
            this.DTuong_SDT.Width = 100;
            // 
            // DTuong_CCCD
            // 
            this.DTuong_CCCD.Caption = "CMND / CCCD";
            this.DTuong_CCCD.FieldName = "DTuong_CCCD";
            this.DTuong_CCCD.Name = "DTuong_CCCD";
            this.DTuong_CCCD.OptionsColumn.ReadOnly = true;
            this.DTuong_CCCD.Visible = true;
            this.DTuong_CCCD.VisibleIndex = 7;
            this.DTuong_CCCD.Width = 100;
            // 
            // DTuong_BHYT
            // 
            this.DTuong_BHYT.Caption = "Thẻ BHYT";
            this.DTuong_BHYT.FieldName = "DTuong_BHYT";
            this.DTuong_BHYT.Name = "DTuong_BHYT";
            this.DTuong_BHYT.OptionsColumn.ReadOnly = true;
            this.DTuong_BHYT.Visible = true;
            this.DTuong_BHYT.VisibleIndex = 8;
            this.DTuong_BHYT.Width = 100;
            // 
            // NhomDT
            // 
            this.NhomDT.Caption = "Nhóm ĐT";
            this.NhomDT.FieldName = "NhomDT";
            this.NhomDT.Name = "NhomDT";
            this.NhomDT.OptionsColumn.ReadOnly = true;
            this.NhomDT.Visible = true;
            this.NhomDT.VisibleIndex = 9;
            this.NhomDT.Width = 450;
            // 
            // DTuong_Tinh
            // 
            this.DTuong_Tinh.Caption = "Tỉnh";
            this.DTuong_Tinh.FieldName = "DTuong_Tinh";
            this.DTuong_Tinh.Name = "DTuong_Tinh";
            this.DTuong_Tinh.OptionsColumn.ReadOnly = true;
            this.DTuong_Tinh.Visible = true;
            this.DTuong_Tinh.VisibleIndex = 10;
            this.DTuong_Tinh.Width = 100;
            // 
            // DTuong_TinhCode
            // 
            this.DTuong_TinhCode.Caption = "Mã tỉnh";
            this.DTuong_TinhCode.FieldName = "DTuong_TinhCode";
            this.DTuong_TinhCode.Name = "DTuong_TinhCode";
            this.DTuong_TinhCode.OptionsColumn.ReadOnly = true;
            this.DTuong_TinhCode.Visible = true;
            this.DTuong_TinhCode.VisibleIndex = 11;
            this.DTuong_TinhCode.Width = 100;
            // 
            // DTuong_Quan
            // 
            this.DTuong_Quan.Caption = "Quận";
            this.DTuong_Quan.FieldName = "DTuong_Quan";
            this.DTuong_Quan.Name = "DTuong_Quan";
            this.DTuong_Quan.OptionsColumn.ReadOnly = true;
            this.DTuong_Quan.Visible = true;
            this.DTuong_Quan.VisibleIndex = 12;
            this.DTuong_Quan.Width = 100;
            // 
            // DTuong_QuanCode
            // 
            this.DTuong_QuanCode.Caption = "Mã Quận";
            this.DTuong_QuanCode.FieldName = "DTuong_QuanCode";
            this.DTuong_QuanCode.Name = "DTuong_QuanCode";
            this.DTuong_QuanCode.OptionsColumn.ReadOnly = true;
            this.DTuong_QuanCode.Visible = true;
            this.DTuong_QuanCode.VisibleIndex = 13;
            this.DTuong_QuanCode.Width = 100;
            // 
            // DTuong_Xa
            // 
            this.DTuong_Xa.Caption = "Xã";
            this.DTuong_Xa.FieldName = "DTuong_Xa";
            this.DTuong_Xa.Name = "DTuong_Xa";
            this.DTuong_Xa.OptionsColumn.ReadOnly = true;
            this.DTuong_Xa.Visible = true;
            this.DTuong_Xa.VisibleIndex = 14;
            this.DTuong_Xa.Width = 100;
            // 
            // DTuong_XaCode
            // 
            this.DTuong_XaCode.Caption = "Mã Xã";
            this.DTuong_XaCode.FieldName = "DTuong_XaCode";
            this.DTuong_XaCode.Name = "DTuong_XaCode";
            this.DTuong_XaCode.OptionsColumn.ReadOnly = true;
            this.DTuong_XaCode.Visible = true;
            this.DTuong_XaCode.VisibleIndex = 15;
            this.DTuong_XaCode.Width = 100;
            // 
            // DTuong_DCCtiet
            // 
            this.DTuong_DCCtiet.Caption = "Đ/C chi tiết";
            this.DTuong_DCCtiet.FieldName = "DTuong_DCCtiet";
            this.DTuong_DCCtiet.Name = "DTuong_DCCtiet";
            this.DTuong_DCCtiet.OptionsColumn.ReadOnly = true;
            this.DTuong_DCCtiet.Visible = true;
            this.DTuong_DCCtiet.VisibleIndex = 16;
            this.DTuong_DCCtiet.Width = 350;
            // 
            // isTimeAdd
            // 
            this.isTimeAdd.Caption = "Time Upload";
            this.isTimeAdd.FieldName = "isTimeAdd";
            this.isTimeAdd.Name = "isTimeAdd";
            this.isTimeAdd.OptionsColumn.ReadOnly = true;
            this.isTimeAdd.Visible = true;
            this.isTimeAdd.VisibleIndex = 17;
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
            this.btnDelete.Location = new System.Drawing.Point(267, 11);
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
            this.btnEdit.Location = new System.Drawing.Point(144, 11);
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
            this.btnAdd.Location = new System.Drawing.Point(32, 11);
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
            // GridDtuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "GridDtuong";
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEdit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_ma;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_ten;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_nsinh;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_GTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_DVCtac;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_CCCD;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_BHYT;
        private DevExpress.XtraGrid.Columns.GridColumn NhomDT;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_Tinh;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_TinhCode;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_Quan;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_QuanCode;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_Xa;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_XaCode;
        private DevExpress.XtraGrid.Columns.GridColumn DTuong_DCCtiet;
        private DevExpress.XtraGrid.Columns.GridColumn isTimeAdd;
    }
}

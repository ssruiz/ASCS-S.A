﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.panelBuscar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.cboxBuscar = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.panelOperaciones = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCambiarContra = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosList = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductoAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miModificarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientesListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientesOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClienteAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElimiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProveedoresListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProveedoresOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProvAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProvModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProvEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendedoresListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendOperaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVendEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMovimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.miGenerarCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.pnlControles.SuspendLayout()
        Me.panelBuscar.SuspendLayout()
        Me.panelOperaciones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(90, 269)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(812, 251)
        Me.dgvDatos.TabIndex = 34
        Me.dgvDatos.Visible = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTitulo.BackgroundImage = Global.Escritorio.My.Resources.Resources._4_bg_top
        Me.PanelTitulo.Controls.Add(Me.lblTitulo)
        Me.PanelTitulo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitulo.Location = New System.Drawing.Point(90, 173)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(812, 72)
        Me.PanelTitulo.TabIndex = 33
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(347, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(70, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label4"
        '
        'pnlControles
        '
        Me.pnlControles.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlControles.BackgroundImage = Global.Escritorio.My.Resources.Resources.fondo_06
        Me.pnlControles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlControles.Controls.Add(Me.panelBuscar)
        Me.pnlControles.Controls.Add(Me.panelOperaciones)
        Me.pnlControles.Location = New System.Drawing.Point(90, 36)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(812, 105)
        Me.pnlControles.TabIndex = 31
        '
        'panelBuscar
        '
        Me.panelBuscar.BackColor = System.Drawing.Color.Transparent
        Me.panelBuscar.Controls.Add(Me.Label3)
        Me.panelBuscar.Controls.Add(Me.Label1)
        Me.panelBuscar.Controls.Add(Me.cbTipoBusqueda)
        Me.panelBuscar.Controls.Add(Me.cboxBuscar)
        Me.panelBuscar.Controls.Add(Me.btnBuscar)
        Me.panelBuscar.Controls.Add(Me.txtBusqueda)
        Me.panelBuscar.Location = New System.Drawing.Point(0, 20)
        Me.panelBuscar.Name = "panelBuscar"
        Me.panelBuscar.Size = New System.Drawing.Size(487, 80)
        Me.panelBuscar.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Búsqueda/Filtro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar por:"
        '
        'cbTipoBusqueda
        '
        Me.cbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoBusqueda.FormattingEnabled = True
        Me.cbTipoBusqueda.Items.AddRange(New Object() {"Herrajes", "Perfiles"})
        Me.cbTipoBusqueda.Location = New System.Drawing.Point(176, 15)
        Me.cbTipoBusqueda.Name = "cbTipoBusqueda"
        Me.cbTipoBusqueda.Size = New System.Drawing.Size(150, 21)
        Me.cbTipoBusqueda.TabIndex = 3
        Me.cbTipoBusqueda.Visible = False
        '
        'cboxBuscar
        '
        Me.cboxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBuscar.FormattingEnabled = True
        Me.cboxBuscar.Location = New System.Drawing.Point(38, 42)
        Me.cboxBuscar.Name = "cboxBuscar"
        Me.cboxBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cboxBuscar.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(351, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(176, 42)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(150, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'panelOperaciones
        '
        Me.panelOperaciones.BackColor = System.Drawing.Color.Transparent
        Me.panelOperaciones.Controls.Add(Me.Label2)
        Me.panelOperaciones.Controls.Add(Me.btnAgregar)
        Me.panelOperaciones.Controls.Add(Me.btnEliminar)
        Me.panelOperaciones.Controls.Add(Me.btnModificar)
        Me.panelOperaciones.Location = New System.Drawing.Point(507, 20)
        Me.panelOperaciones.Name = "panelOperaciones"
        Me.panelOperaciones.Size = New System.Drawing.Size(305, 80)
        Me.panelOperaciones.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operaciones"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(27, 42)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(211, 42)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(120, 42)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.Escritorio.My.Resources.Resources.fondo_06
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSesion, Me.miProductos, Me.miClientes, Me.miProveedores, Me.miVendedores, Me.miMovimientos, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 33)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'miSesion
        '
        Me.miSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCambiarContra, Me.CerrarToolStripMenuItem})
        Me.miSesion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miSesion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miSesion.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miSesion.Name = "miSesion"
        Me.miSesion.Size = New System.Drawing.Size(54, 18)
        Me.miSesion.Text = "Sesión"
        '
        'miCambiarContra
        '
        Me.miCambiarContra.Name = "miCambiarContra"
        Me.miCambiarContra.Size = New System.Drawing.Size(181, 22)
        Me.miCambiarContra.Text = "Cambiar Contraseña"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'miProductos
        '
        Me.miProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProductosList, Me.miProductosOper})
        Me.miProductos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miProductos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miProductos.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miProductos.Name = "miProductos"
        Me.miProductos.Size = New System.Drawing.Size(74, 18)
        Me.miProductos.Text = "Productos"
        '
        'miProductosList
        '
        Me.miProductosList.Name = "miProductosList"
        Me.miProductosList.Size = New System.Drawing.Size(141, 22)
        Me.miProductosList.Text = "Listado"
        '
        'miProductosOper
        '
        Me.miProductosOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProductoAgregar, Me.miModificarProducto, Me.EliminarToolStripMenuItem})
        Me.miProductosOper.Name = "miProductosOper"
        Me.miProductosOper.Size = New System.Drawing.Size(141, 22)
        Me.miProductosOper.Text = "Operaciones"
        '
        'miProductoAgregar
        '
        Me.miProductoAgregar.Name = "miProductoAgregar"
        Me.miProductoAgregar.Size = New System.Drawing.Size(121, 22)
        Me.miProductoAgregar.Text = "Agregar"
        '
        'miModificarProducto
        '
        Me.miModificarProducto.Name = "miModificarProducto"
        Me.miModificarProducto.Size = New System.Drawing.Size(121, 22)
        Me.miModificarProducto.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'miClientes
        '
        Me.miClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miClientesListado, Me.miClientesOper})
        Me.miClientes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miClientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miClientes.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miClientes.Name = "miClientes"
        Me.miClientes.Size = New System.Drawing.Size(61, 18)
        Me.miClientes.Text = "Clientes"
        '
        'miClientesListado
        '
        Me.miClientesListado.Name = "miClientesListado"
        Me.miClientesListado.Size = New System.Drawing.Size(141, 22)
        Me.miClientesListado.Text = "Listado"
        '
        'miClientesOper
        '
        Me.miClientesOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miClienteAgregar, Me.ModificarToolStripMenuItem1, Me.ElimiarToolStripMenuItem})
        Me.miClientesOper.Name = "miClientesOper"
        Me.miClientesOper.Size = New System.Drawing.Size(141, 22)
        Me.miClientesOper.Text = "Operaciones"
        '
        'miClienteAgregar
        '
        Me.miClienteAgregar.Name = "miClienteAgregar"
        Me.miClienteAgregar.Size = New System.Drawing.Size(121, 22)
        Me.miClienteAgregar.Text = "Agregar"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'ElimiarToolStripMenuItem
        '
        Me.ElimiarToolStripMenuItem.Name = "ElimiarToolStripMenuItem"
        Me.ElimiarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ElimiarToolStripMenuItem.Text = "Eliminar"
        '
        'miProveedores
        '
        Me.miProveedores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProveedoresListado, Me.miProveedoresOper})
        Me.miProveedores.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miProveedores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miProveedores.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miProveedores.Name = "miProveedores"
        Me.miProveedores.Size = New System.Drawing.Size(87, 18)
        Me.miProveedores.Text = "Proveedores"
        '
        'miProveedoresListado
        '
        Me.miProveedoresListado.Name = "miProveedoresListado"
        Me.miProveedoresListado.Size = New System.Drawing.Size(141, 22)
        Me.miProveedoresListado.Text = "Listado"
        '
        'miProveedoresOper
        '
        Me.miProveedoresOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProvAgregar, Me.miProvModificar, Me.miProvEliminar})
        Me.miProveedoresOper.Name = "miProveedoresOper"
        Me.miProveedoresOper.Size = New System.Drawing.Size(141, 22)
        Me.miProveedoresOper.Text = "Operaciones"
        '
        'miProvAgregar
        '
        Me.miProvAgregar.Name = "miProvAgregar"
        Me.miProvAgregar.Size = New System.Drawing.Size(121, 22)
        Me.miProvAgregar.Text = "Agregar"
        '
        'miProvModificar
        '
        Me.miProvModificar.Name = "miProvModificar"
        Me.miProvModificar.Size = New System.Drawing.Size(121, 22)
        Me.miProvModificar.Text = "Modificar"
        '
        'miProvEliminar
        '
        Me.miProvEliminar.Name = "miProvEliminar"
        Me.miProvEliminar.Size = New System.Drawing.Size(121, 22)
        Me.miProvEliminar.Text = "Eliminar"
        '
        'miVendedores
        '
        Me.miVendedores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miVendedoresListado, Me.miVendOperaciones})
        Me.miVendedores.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miVendedores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miVendedores.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miVendedores.Name = "miVendedores"
        Me.miVendedores.Size = New System.Drawing.Size(85, 18)
        Me.miVendedores.Text = "Vendedores"
        '
        'miVendedoresListado
        '
        Me.miVendedoresListado.Name = "miVendedoresListado"
        Me.miVendedoresListado.Size = New System.Drawing.Size(141, 22)
        Me.miVendedoresListado.Text = "Listado"
        '
        'miVendOperaciones
        '
        Me.miVendOperaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miVendAgregar, Me.miVendModificar, Me.miVendEliminar})
        Me.miVendOperaciones.Name = "miVendOperaciones"
        Me.miVendOperaciones.Size = New System.Drawing.Size(141, 22)
        Me.miVendOperaciones.Text = "Operaciones"
        '
        'miVendAgregar
        '
        Me.miVendAgregar.Name = "miVendAgregar"
        Me.miVendAgregar.Size = New System.Drawing.Size(121, 22)
        Me.miVendAgregar.Text = "Agregar"
        '
        'miVendModificar
        '
        Me.miVendModificar.Name = "miVendModificar"
        Me.miVendModificar.Size = New System.Drawing.Size(121, 22)
        Me.miVendModificar.Text = "Modificar"
        '
        'miVendEliminar
        '
        Me.miVendEliminar.Name = "miVendEliminar"
        Me.miVendEliminar.Size = New System.Drawing.Size(121, 22)
        Me.miVendEliminar.Text = "Eliminar"
        '
        'miMovimientos
        '
        Me.miMovimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCompras})
        Me.miMovimientos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miMovimientos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.miMovimientos.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.miMovimientos.Name = "miMovimientos"
        Me.miMovimientos.Size = New System.Drawing.Size(86, 18)
        Me.miMovimientos.Text = "Movimientos"
        '
        'miCompras
        '
        Me.miCompras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miGenerarCompra})
        Me.miCompras.Name = "miCompras"
        Me.miCompras.Size = New System.Drawing.Size(120, 22)
        Me.miCompras.Text = "Compras"
        '
        'miGenerarCompra
        '
        Me.miGenerarCompra.Name = "miGenerarCompra"
        Me.miGenerarCompra.Size = New System.Drawing.Size(162, 22)
        Me.miGenerarCompra.Text = "Generar Compra"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReportesToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(68, 18)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Inicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(963, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casa Marco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.pnlControles.ResumeLayout(False)
        Me.panelBuscar.ResumeLayout(False)
        Me.panelBuscar.PerformLayout()
        Me.panelOperaciones.ResumeLayout(False)
        Me.panelOperaciones.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelBuscar As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents panelOperaciones As System.Windows.Forms.Panel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents SesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents miSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductosList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductosOper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductoAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miModificarProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents cboxBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents miClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClientesListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClientesOper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClienteAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElimiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents pnlControles As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents miProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProveedoresListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProveedoresOper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProvAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProvModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProvEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendedoresListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendOperaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miVendEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miMovimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents miCompras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miGenerarCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miCambiarContra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvDatos As DataGridView
End Class

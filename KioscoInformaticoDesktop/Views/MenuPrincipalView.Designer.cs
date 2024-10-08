﻿namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuItemPrincipal = new FontAwesome.Sharp.IconMenuItem();
            MenuItemBases = new FontAwesome.Sharp.IconMenuItem();
            MenuItemLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemProducto = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemClientes = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemProveedores = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuItemSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemPrincipal, MenuItemBases, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemPrincipal
            // 
            MenuItemPrincipal.ForeColor = Color.Black;
            MenuItemPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            MenuItemPrincipal.IconColor = Color.Black;
            MenuItemPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemPrincipal.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemPrincipal.Name = "MenuItemPrincipal";
            MenuItemPrincipal.Size = new Size(113, 52);
            MenuItemPrincipal.Text = "Principal";
            // 
            // MenuItemBases
            // 
            MenuItemBases.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLocalidades, iconMenuItemProducto, iconMenuItemClientes, iconMenuItemProveedores });
            MenuItemBases.IconChar = FontAwesome.Sharp.IconChar.Database;
            MenuItemBases.IconColor = Color.Black;
            MenuItemBases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemBases.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemBases.Name = "MenuItemBases";
            MenuItemBases.Size = new Size(96, 52);
            MenuItemBases.Text = "Bases";
            // 
            // MenuItemLocalidades
            // 
            MenuItemLocalidades.IconChar = FontAwesome.Sharp.IconChar.LocationPin;
            MenuItemLocalidades.IconColor = Color.Black;
            MenuItemLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemLocalidades.IconSize = 28;
            MenuItemLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemLocalidades.Name = "MenuItemLocalidades";
            MenuItemLocalidades.Size = new Size(192, 34);
            MenuItemLocalidades.Text = "Localidades";
            MenuItemLocalidades.Click += MenuItemLocalidades_Click;
            // 
            // iconMenuItemProducto
            // 
            iconMenuItemProducto.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            iconMenuItemProducto.IconColor = Color.Black;
            iconMenuItemProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemProducto.IconSize = 28;
            iconMenuItemProducto.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemProducto.Name = "iconMenuItemProducto";
            iconMenuItemProducto.Size = new Size(192, 34);
            iconMenuItemProducto.Text = "Productos";
            iconMenuItemProducto.Click += iconMenuItemProducto_Click;
            // 
            // iconMenuItemClientes
            // 
            iconMenuItemClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuItemClientes.IconColor = Color.Black;
            iconMenuItemClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemClientes.IconSize = 28;
            iconMenuItemClientes.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItemClientes.Name = "iconMenuItemClientes";
            iconMenuItemClientes.Size = new Size(192, 34);
            iconMenuItemClientes.Text = "Clientes";
            iconMenuItemClientes.Click += iconMenuItemClientes_Click;
            // 
            // iconMenuItemProveedores
            // 
            iconMenuItemProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItemProveedores.IconColor = Color.Black;
            iconMenuItemProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemProveedores.Name = "iconMenuItemProveedores";
            iconMenuItemProveedores.Size = new Size(192, 34);
            iconMenuItemProveedores.Text = "Proveedores";
            iconMenuItemProveedores.Click += iconMenuItemProveedores_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSalirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(89, 52);
            iconMenuItem2.Text = "Salir";
            // 
            // MenuItemSalirDelSistema
            // 
            MenuItemSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            MenuItemSalirDelSistema.IconColor = Color.Black;
            MenuItemSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuItemSalirDelSistema.IconSize = 32;
            MenuItemSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            MenuItemSalirDelSistema.Name = "MenuItemSalirDelSistema";
            MenuItemSalirDelSistema.Size = new Size(175, 38);
            MenuItemSalirDelSistema.Text = "Salir del Sistema";
            MenuItemSalirDelSistema.Click += MenuItemSalirDelSistema_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informatico Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuItemPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem MenuItemBases;
        private FontAwesome.Sharp.IconMenuItem MenuItemSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem MenuItemLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProducto;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemClientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemProveedores;
    }
}

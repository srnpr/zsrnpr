<%@ Page Title="" Language="C#" MasterPageFile="~/AllZsrnprDebug.Master" AutoEventWireup="true" CodeBehind="InitWebConfig.aspx.cs" Inherits="ZsrnprWeb.ZsrnprDebug.InitWebConfig" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Master_Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Master_Content" runat="server">
    <asp:Button ID="bCreateDefault" runat="server" onclick="bCreateDefault_Click" 
        Text="生成默认配置文件" />
</asp:Content>

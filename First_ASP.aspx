<%-- 첫 ASP.NET 예제 --%> 

<%@ Page Title="게시판 3" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Board.aspx.cs" Inherits="BoardTest.Contact" %>

<%--
    페이지 이름  = 게시판 3
    언어 = C# 
    주페이지 = Site.Master 
    AutoEventWriteUp 이건 뭘까 
    CodeBehind = ??
    Inherits = 상속받기 
--%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> 게시판 테스트 페이지 </h2> <%-- 게시판 페이지 대제목 --%>
    <h3>게시판 테스트 페이지</h3> <%-- 게시판 페이지 중제목  --%>
    <contents>
        <form method="get" action="board_write.html">
        <strong>제목</strong> <%-- <b>와 다르게, 글자 뜻 그대로 강조!! --%>
        <input type="text" size="70" name="title"/> <%-- input 개체, 입력 값 받아오기 --%>
        <strong>게시자</strong>
        <input type="text" size="30" name="writer"/>
        <hr>
        <strong>내용</strong><br />
        <textarea cols="100" rows="5" name="contents"></textarea> <%-- input이 단순히 한줄 값을 받아오면, textaera는 다중, 다량 --%>
        <hr />
        <br />
        <input type="submit" value="Upload" /> 
        <input type="button" value ="Cancel" />
        </form>
    </contents>


   
</asp:Content>

function setlocation(boardID, id, author, content)
{ 
    var note = document.getElementById(id);
    //alert("left = " + note.offsetLeft + " top = " + note.offsetTop);
    //alert("at function");
    var xCoordinate = note.offsetLeft;
    var yCoordinate = note.offsetTop;
    var zCoordinate = note.offsetTop;
    $.ajax(
        {
            url: "/Note/EditPosition",
            type: "POST",
            data: { 'boardID': boardID, 'noteID': id, 'author': author, 'content': content, 'xCoordinate': xCoordinate, 'yCoordinate': yCoordinate, 'zCoordinate': zCoordinate},
            success: function () { }
            });
}
function setlocation(id)
{ 
    var note = document.getElementById(id);
    //alert("left = " + note.offsetLeft + " top = " + note.offsetTop);
    alert("at function");
    var xcoordinate = note.offsetLeft;
    var ycoordinate = note.offsetTop;
    $.ajax(
        {
            url: "/Note/EditPosition",
            type: "POST",
            data: { 'noteID': id, 'xcoordinate': xcoordinate, 'ycoordinate': ycoordinate, 'boardid': 1},
            success: function () { alert('xcoordinate = ' + xcoordinate); }
            });
}
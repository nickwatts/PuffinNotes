function setlocation(boardID, author, content)
{ 

    var allnotes = $('.note');


    for (var i = 0; i < allnotes.length; i++)
    {
        var note = allnotes[i];

        var xCoordinate = note.offsetLeft;
        var yCoordinate = note.offsetTop;
        var zCoordinate = parseInt(note.style.zIndex); // + 1;//$(note).css('zIndex');
       
        //note.innerText = note.innerText + " Zindex= " + note.style.zIndex;
    $.ajax(
        {
            url: "/Note/EditPosition",
            type: "POST",
            data: { 'boardID': boardID, 'noteID': note.id, 'author': author, 'content': note.innerText, 'xCoordinate': xCoordinate, 'yCoordinate': yCoordinate, 'zCoordinate': zCoordinate},
            success: function () { }
            });

    }


}


function getElements(attrib)
{

    return $('[' + attrib + ']').get();
}

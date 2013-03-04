//Sets controls with a class of DraggableListItem as draggable using JQueryUI
$(function () {
    $(".DraggableListItem").draggable({ containment: ".NoticeBoard", scroll: false });
});
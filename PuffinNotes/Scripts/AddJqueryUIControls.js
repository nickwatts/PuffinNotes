//Sets controls with a class of DraggableListItem as draggable using JQueryUI
$(function () {
    $(".note").draggable({ containment: ".noticeboard", scroll: false });
});
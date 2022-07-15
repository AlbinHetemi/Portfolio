
$('.emratSkills').hide();
$('.Skills').hover(function () {
    var elementi = $(this).find('h3');
    elementi.slideDown(400);
})
$('.Skills').mouseleave(function () {
    var elementi = $(this).find('h3');
    elementi.slideUp(400);
})
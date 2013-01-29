$(function () {
    $(window).scroll(function () {
        if ($(window).scrollTop() >= 300)//距离顶部多少高度显示按钮
        {
            $('#goTopBtn').fadeIn(200);
        } else {
            $('#goTopBtn').fadeOut(200);
        }
    });

    $('#goTopBtn').click(function () {
        $('body,html').animate({ scrollTop: 0 }, 500)
    });

    //按钮定位
    var win_width = $(window).width();      //窗口宽度
    var content_width = $('#Container').width();     //容器宽度
 
    var topbtn_width = $('#goTopBtn').width(); //按钮宽度
    //alert([win_width - content_width]/2);

    //距离主体部分的右侧距离
    var topbtn_posi = ([win_width - content_width] / 2 - topbtn_width - 10);
    $('#goTopBtn').css({ 'right': topbtn_posi });

})
$(function() {
	var w_height = $(window).height();
	
	$('.main_block').css('min-height', w_height);
	$(window).resize(function(){
		$('.main_block').css('min-height', w_height);
	});	
	
	$('#top_menu a').click(function(e){
		e.preventDefault();
		var href = $(this).attr('href'),
			scroll = 0;
			
		if(href == "#top") scroll = 0;
		else scroll = $(href).offset().top;
		
		$('body').animate({
			scrollTop: scroll
		}, 1000);
	});
	
	$('[data-modal="modal"]').click(function(e){
		e.preventDefault();
		$('.modal').addClass('hidden');
		$($(this).attr('href')).removeClass('hidden');
		$('.fade_bckgr').removeClass('hidden');
	});
	
	$('.modal .close').click(function(e){
		e.preventDefault();
		$(this).parents('.modal').addClass('hidden');
		$('.fade_bckgr').addClass('hidden');
	});
	
	$('.checked_user').click(function(){
		$('.checked_user').removeClass('active');
		$(this).addClass('active');
	});	
		
});
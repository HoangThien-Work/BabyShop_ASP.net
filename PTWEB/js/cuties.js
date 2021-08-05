jQuery(document).ready(function($){
	
	$('#mobile-menu').prepend('<div id="mobile-menu-icon">MENU</div>');
	$("#mobile-menu-icon").on("click", function(){
		$("#mobile-menu-nav").slideToggle();
		$(this).toggleClass("active");
	});
	
	$('.mobile-footer-menu div').hide();  
  	
	$('.mobile-footer-menu h3').click(function() {
    	$(this).next('div').slideToggle()
    	.siblings('div:visible').slideUp();
  	});
	
	$('.button-search').bind('click', function() {
		url = $('base').attr('href') + 'index.html'; 
		var search = $('input[name=\'search\']').attr('value');
		if (search) {
			url += '&search=' + encodeURIComponent(search);
		}
		location = url;
	});
	
	$('#header input[name=\'search\']').bind('keydown', function(e) {
		if (e.keyCode == 13) {
			url = $('base').attr('href') + 'index.html';
			var search = $('input[name=\'search\']').attr('value');
			if (search) {
				url += '&search=' + encodeURIComponent(search);
			}
			location = url;
		}
	});
	
	$('#menu ul > li > a + div').each(function(index, element) {
		if ($.browser.msie && ($.browser.version == 7 || $.browser.version == 6)) {
			var category = $(element).find('a');
			var columns = $(element).find('ul').length;
			
			$(element).css('width', (columns * 143) + 'px');
			$(element).find('ul').css('float', 'left');
		}
		var menu = $('#menu').offset();
		var dropdown = $(this).parent().offset();
		i = (dropdown.left + $(this).outerWidth()) - (menu.left + $('#menu').outerWidth());
		if (i > 0) {
			$(this).css('margin-left', '-' + (i + 5) + 'px');
		}
	});
	
	if ($.browser.msie) {
		if ($.browser.version <= 6) {
			$('#column-left + #column-right + #content, #column-left + #content').css('margin-left', '195px');
			$('#column-right + #content').css('margin-right', '195px');
			$('.box-category ul li a.active + ul').css('display', 'block');	
		}
		if ($.browser.version <= 7) {
			$('#menu > ul > li').bind('mouseover', function() {
				$(this).addClass('active');
			});
			$('#menu > ul > li').bind('mouseout', function() {
				$(this).removeClass('active');
			});	
		}
	}
	
	$('#cart > .heading a').live('click', function() {
		$('#cart').addClass('active');
		$('#cart').live('mouseleave', function() {
			$(this).removeClass('active');
		});
	});
	
	$('#slider').before('<div id="sliderthumbs" class="sliderthumbs">').cycle({
	pager:  '#sliderthumbs'  
	});
	
	$('#carousel ul').jcarousel({
	vertical: false,
	visible: 5,
	scroll: 3
	});
	
	$.fn.tabs = function() {
	var selector = this;
	this.each(function() {
		var obj = $(this); 
		$(obj.attr('href')).hide();
		obj.click(function() {
			$(selector).removeClass('selected');
			$(this).addClass('selected');
			$($(this).attr('href')).fadeIn();
			$(selector).not(this).each(function(i, element) {
				$($(element).attr('href')).hide();
			});
			return false;
		});
	});
	$(this).show();
	$(this).first().click();
};

$(function () { 
    $("SELECT").selectBox(); 
});

$('.checkout-heading').live('click', function() {
	$('.checkout-content').slideUp('slow');
	
	$(this).parent().find('.checkout-content').slideDown('slow');
});
	
$.fn.tabs = function() {
	var selector = this;
	this.each(function() {
		var obj = $(this); 
		$(obj.attr('href')).hide();
		obj.click(function() {
			$(selector).removeClass('selected');
			$(this).addClass('selected');
			$($(this).attr('href')).fadeIn();
			$(selector).not(this).each(function(i, element) {
				$($(element).attr('href')).hide();
			});
			return false;
		});
	});
	$(this).show();
	$(this).first().click();
};	
	
$('#tabs a').tabs();

});

function display(view) {
	if (view == 'list') {
		$('.product-grid').attr('class', 'product-list');
		$('.display').html('<label>Display:</label><p><span id="list" class="list_on"></span> <span id="grid" onclick="display(\'grid\');"></span></p>');
	} else {
		$('.product-list').attr('class', 'product-grid');					
		$('.display').html('<label>Display:</label><p><span id="list" onclick="display(\'list\');"></span><span id="grid" class="grid_on"></span></p>');
	}
}
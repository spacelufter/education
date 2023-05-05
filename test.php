<?php
/**
* The header for our theme.
*
* This is the template that displays all of the <head> section and everything up until <div id="content">
*
* @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
*
* @package _s
*/
$page_id = get_the_ID(); 
?>
<!DOCTYPE html>
<html <?php language_attributes(); ?>>
<head>
	<!-- DataDog RUM -->
	<script>
		(function(h,o,u,n,d) {
			h=h[d]=h[d]||{q:[],onReady:function(c){h.q.push(c)}}
			d=o.createElement(u);d.async=1;d.src=n
			n=o.getElementsByTagName(u)[0];n.parentNode.insertBefore(d,n)
		})(window,document,'script','https://www.datadoghq-browser-agent.com/datadog-rum-v4.js','DD_RUM')
		DD_RUM.onReady(function() {
			DD_RUM.init({
				clientToken: 'pub9f263403bb8a47cd90b9b7e7c68394af',
				applicationId: '052ea962-ee78-41c0-87a8-127e90d166c3',
				site: 'datadoghq.com',
				service:'loopreturns.com',
			// Specify a version number or environment to identify in Datadog 
			// version: '1.0.0',
			// env:'prod', 
			sampleRate: 100,
			trackInteractions: true,
			defaultPrivacyLevel: 'allow'
		});
			
			DD_RUM.startSessionReplayRecording();
		})
	</script>
	<!-- End of DataDog RUM Code -->
	<!-- Start of Async Drift Code -->
	<script>
		"use strict";

		!function() {
			var t = window.driftt = window.drift = window.driftt || [];
			if (!t.init) {
				if (t.invoked) return void (window.console && console.error && console.error("Drift snippet included twice."));
				t.invoked = !0, t.methods = [ "identify", "config", "track", "reset", "debug", "show", "ping", "page", "hide", "off", "on" ],
				t.factory = function(e) {
					return function() {
						var n = Array.prototype.slice.call(arguments);
						return n.unshift(e), t.push(n), t;
					};
				}, t.methods.forEach(function(e) {
					t[e] = t.factory(e);
				}), t.load = function(t) {
					var e = 3e5, n = Math.ceil(new Date() / e) * e, o = document.createElement("script");
					o.type = "text/javascript", o.async = !0, o.crossorigin = "anonymous", o.src = "https://js.driftt.com/include/" + n + "/" + t + ".js";
					var i = document.getElementsByTagName("script")[0];
					i.parentNode.insertBefore(o, i);
				};
			}
		}();
		drift.SNIPPET_VERSION = '0.3.1';
		window.drift_init_options = {loadType: 'ON_INTERACTIVE'}
		drift.load('63nuwe8w9g6b');
		drift.on('ready', function (api, payload) {
			window.drift.on("startConversation", function (data) {
				console.log("User started a new conversation " + JSON.stringify(data));
				drift.api.setUserAttributes({ drift_contact_id: data.endUserId.toString() });
			});
		});

		drift.config({ cookieDomain: ".loopreturns.com" });
	</script>
	<!-- End of Async Drift Code -->
	<!-- Google Tag Manager -->
	<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
		new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
	j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
	'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-MZW84SN');</script>
<!-- End Google Tag Manager -->
<script async src="https://www.googleoptimize.com/optimize.js?id=OPT-NXRCLH7"></script>
<script src="https://cmp.osano.com/AzZXFfTaCNrVFG0EM/96714474-843d-40b3-854b-3d1f759d5372/osano.js"></script>
<meta charset="<?php bloginfo( 'charset' ); ?>">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="profile" href="http://gmpg.org/xfn/11">
<link rel="pingback" href="<?php bloginfo('pingback_url'); ?>">

<?php wp_head(); ?>

</head>
<?php 
$current_menu = is_single() || is_404() || is_archive() ? 'main-menu' : get_field('navigation_bar', $page_id);
$show_navigation_bar = get_field('show_navigation_bar', $page_id);
$show_only_logo = get_field('show_only_the_logo', $page_id);
$overlap_navigation_bar = get_field('overlap_navigation_bar', $page_id);
$button_title = get_field('nav_cta_button', 'options')['title'];
$button_url = get_field('nav_cta_button', 'options')['url'];
$button_target = get_field('nav_cta_button', 'options')['target'];
$menuitems = wp_get_nav_menu_items( $current_menu, array( 'order' => 'DESC' ) );
$navigation_theme = get_field('navigation_theme', $page_id);
$show_announcement_banner_single = get_field('show_announcement_banner', $page_id);
switch ($navigation_theme) {
	case 'dark':
	$background_color = 'bg-black';
	$text_color = 'text-white';
	break;
	case 'light':
	$background_color = 'bg-white';
	$text_color = 'text-black';
	break;
	case 'salmon':
	$background_color = 'bg-brand-salmon';
	$text_color = 'text-black';
	break;
}
?>
<body <?php body_class(); ?> id="top" data-title="<?=wp_title('')?>">
	<!-- Google Tag Manager (noscript) -->
	<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-MZW84SN"
		height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
		<!-- End Google Tag Manager (noscript) -->
		<?php 
		$ann_text = get_field('text_ann', 'options');
		$ann_url = get_field('url_ann', 'options');
		$show_announcement_banner = get_field('show_banner_everywhere', 'options');
		$sticky_banner = get_field('sticky_banner', 'options');
		?>

		<?php if( $show_announcement_banner == 'show' ): ?>
			<?php if( !$sticky_banner || is_null($sticky_banner) ): ?>
				<?php if ($ann_text): ?>
					<div class="w-full top-0 <?php if ($navigation_theme == "dark"): ?>bg-white text-black<?php else: ?>bg-black text-white<?php endif;?>" style="transform: none;">
						<a target="_blank" rel="noopener noreferrer" href="<?= $ann_url ?>" class="flex justify-center items-center py-1 lg:py-1/4 px-outer-mobile lg:px-sm">
							<p class="text-[2.933vw] lg:text-[1.111vw] font-medium text-center uppercase">
								<?= $ann_text ?>
							</p>
							<svg viewBox="0 0 18 11" fill="none" xmlns="http://www.w3.org/2000/svg" class="flex-shrink-0 ml-[1vw] lg:ml-[0.5vw] w-[4vw] lg:w-[1.2vw]"><path d="M0 5.321h16.845M13.062.686L17 5.321l-3.938 4.635" stroke="currentColor" stroke-width="1.364"></path></svg>
						</a>
					</div>
				<?php endif; ?>
			<?php endif; ?>
		<?php endif; ?>

		<?php if ($show_navigation_bar == "show" || is_single() || is_404()): ?>
		<?php if ($current_menu || is_single() || is_404()): ?>
		<header class="loop-main-navigation items-center left-0 z-[999] flex flex-col w-full  text-black <?= $overlap_navigation_bar == "on" ? 'absolute top-15 bg-transparent' : 'top-0 bg-white relative' ?>  <?= $navigation_theme ?>">

			<?php if( $show_announcement_banner == 'show' ): ?>
				<?php if( $sticky_banner ): ?>
					<?php if ( $ann_text ): ?>
						<div class="w-full top-0 <?php if ($navigation_theme == "dark"): ?>bg-white text-black<?php else: ?>bg-black text-white<?php endif;?>" style="transform: none;">
							<a target="_blank" rel="noopener noreferrer" href="<?= $ann_url ?>" class="flex justify-center items-center py-1 lg:py-1/4 px-outer-mobile lg:px-sm">
								<p class="text-[2.933vw] lg:text-[1.111vw] font-medium text-center uppercase">
									<?= $ann_text ?>
								</p>
								<svg viewBox="0 0 18 11" fill="none" xmlns="http://www.w3.org/2000/svg" class="flex-shrink-0 ml-[1vw] lg:ml-[0.5vw] w-[4vw] lg:w-[1.2vw]"><path d="M0 5.321h16.845M13.062.686L17 5.321l-3.938 4.635" stroke="currentColor" stroke-width="1.364"></path></svg>
							</a>
						</div>
					<?php endif; ?>
				<?php endif; ?>
			<?php endif; ?>

			<div class="lg:flex justify-between items-center px-x-lg w-full max-w-screen-3xl mx-auto px-5 py-5">
				<a class="w-[27.867vw] lg:w-[7.083vw] h-[6.667vw] lg:h-[2.243vw]" href="/">
					<?php if ($navigation_theme == "dark"): ?>
						<img src="https://images.ctfassets.net/kscjafx0jjrh/3uInIdJBvqMgTw0HBG5hl1/a357b7a3dad46af6245e477c2c978b03/image__2_.svg">
						<?php else: ?>
							<img src="https://images.ctfassets.net/kscjafx0jjrh/4zlnZcMpAM4r1SJNbPFE5Z/fc2c14951d7c590bd71aae7ab30db320/loop-isologo.svg" class="object-contain main-logo w-full h-full w-20 md:w-28 lg:w-28" alt="Loop returns">
						<?php endif ?>
					</a>
					<?php if (!($show_only_logo)): ?>
						<nav class="hidden main-nav nav-theme-<?= $navigation_theme ?> lg:block">
							<ul class="flex items-center text-black font-sans font-medium">
								<?php
								$count = 0;
								$submenu = false;

								foreach( $menuitems as $key => $item ):
									$link = $item->url;
									$title = $item->title;
									$big_title = get_field('title', $item);
									$big_text = get_field('text', $item);
									$image = get_field('image', $item);
									if ( !$item->menu_item_parent ):
										$parent_id = $item->ID;
										?>
										<li class="ml-[1.944vw] <?= ($menuitems[$key+1]->menu_item_parent != 0) ? 'menu-item-has-children-' . $navigation_theme : '' ?>"><a class="link py-7 relative <?= ($navigation_theme == 'dark' ? 'before:bg-white' : 'before:bg-black') ?>" href="<?= $link ?>"><?= $title ?>

										<?php if($menuitems[$key+1]->menu_item_parent != 0): ?>
											<svg class="ml-[0.5vw] w-[0.833vw] transition-transform duration-200 ease-in-out transform group-focus:scale-[-1] svg-arrow-menu" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 11 7"><defs></defs><path stroke="#000000" d="M1 1l4.5 4.5L10 1" fill="none"></path></svg>
										<?php endif; ?>

									</a>
								<?php endif; ?>
								<?php if ( $parent_id == $item->menu_item_parent ): ?>

									<?php if ( !$submenu ): $submenu = true; ?>
										<ul class="sub-menu absolute bottom-3 border-t-[1px] border-b-[1px] border-solid w-full transform translate-y-[100%] py-y-mobile lg:py-y px-x-lg border-current left-0 py-7 <?= $background_color ?>">
											<div class="grid m-auto grid-cols-10 gap-4 w-10/12 sub-menu-wrapper">
											<?php endif; ?>
											<a href="<?= $link ?>" class="item col-span-3 first:col-span-4 first:row-span-2 flex mb-4 sm:mr-4 lg:mb-4  lg:mr-0 sm:mb-0 sm:basis-full box-border rounded-md cursor-pointer h-full min-h-96 <?= $navigation_theme == 'dark' ? 'bg-white' : 'bg-black' ?>">
												<li class="flex flex-col justify-between relative w-full  p-8 lg:py-6 lg:px-8 transition-transform duration-300 hover:translate-x-1 hover:-translate-y-1 rounded-md border border-solid <?= $navigation_theme == 'dark' ? 'border-white bg-black' : 'border-black bg-white' ?> ">
													<div class="font-sans big_title normal-case font-normal <?= $navigation_theme == 'dark' ? 'text-white' : 'text-black' ?>">
														<?= $big_title ?>
													</div>

													<div class="font-sans text-sm font-normal normal-case mt-2 <?= $navigation_theme == 'dark' ? 'text-white' : 'text-black' ?>">
														<?= $big_text ?>
													</div>
													<p class="flex text-sm items-center mt-auto nav-learnmore">
														<span>LEARN MORE</span>
														<svg viewBox="0 0 18 11" fill="none" xmlns="http://www.w3.org/2000/svg" class="dropdown-menu-cards_arrow__3gfZk"><path d="M0 5.321h16.845M13.062.686L17 5.321l-3.938 4.635" stroke="currentColor" stroke-width="1.364"></path></svg>
													</p>
													<img src="<?= $image['url'] ?>" class="absolute right-3 bottom-2 w-20">
												</li>
											</a>
											<?php if ( $menuitems[ $count + 1 ]->menu_item_parent != $parent_id && $submenu ): ?>
											</div>
										</ul>
										<?php $submenu = false; endif; ?>

									<?php endif; ?>

									<?php if ( $menuitems[ $count + 1 ]->menu_item_parent != $parent_id ): ?>
									</li>                           
									<?php $submenu = false; endif; ?>

									<?php $count++; endforeach; ?>
									<div class="hidden lg:block book-a-demo">
										<div class="book-a-demo-container">
											<?= do_shortcode("[button href=\"{$button_url}\" theme=\"brand_dark\" target=\"{$button_target}]{$button_title}[/button]") ?>
										</div>
									</div>
									
								</ul>
							</nav>
						<?php endif ?>
					</div>

					<?php if (!($show_only_logo)): ?>
						<nav class="mobile-menu block lg:hidden px-5 py-5 flex overflow-y-scroll flex-col justify-start w-full min-h-screen bg-white">
							<p class="font-serif text-base mb-2">Love After Purchase</p>
							<ul class="mb-5">
								<?php
								$count = 0;
								$submenu = false;

								foreach( $menuitems as $item ):
									$link = $item->url;
									$title = $item->title;
									$big_title = get_field('title', $item);
									$big_text = get_field('text', $item);
									$image = get_field('image', $item);
									if ( !$item->menu_item_parent ):
										$parent_id = $item->ID;
										?>
										<li class="mb-1 font-medium text-2xl"><a href="<?= $link ?>"><?= $title ?></a>
										<?php endif; ?>
										<?php if ( $parent_id == $item->menu_item_parent ): ?>

											<?php if ( !$submenu ): $submenu = true; ?>
												<ul class="mobile-sub-menu mt-2 mb-4">
													<div class="">
													<?php endif; ?>
													<a href="<?= $link ?>" class="block text-base font-normal pl-5">
														<span class="w-2 h-2 bg-brand-dark inline-block text-transparent rounded-full float-left	mt-[7px] mr-[10px]">.</span>
														<?= $big_title ?>
													</a>
													<?php if ( $menuitems[ $count + 1 ]->menu_item_parent != $parent_id && $submenu ): ?>
													</div>
												</ul>
												<?php $submenu = false; endif; ?>

											<?php endif; ?>

											<?php if ( $menuitems[ $count + 1 ]->menu_item_parent != $parent_id ): ?>
											</li>                           
											<?php $submenu = false; endif; ?>

											<?php $count++; endforeach; ?>
										</ul>
										<div class="mobile-buttons flex flex-col">
											<a href="/contact-loop" class="mb-2 group text-center relative inline-block border px-5 border-brand-dark bg-brand-dark rounded-md overflow-hidden "> <span class="block absolute left-0 inset-y-0 w-full origin-right scale-x-0 transition-transform duration-300 ease-in-out group-hover:scale-x-100 group-hover:origin-left bg-white"></span> <span class="flex items-center space-x-3 py-2 text-base text-white transition-colors duration-300 ease-in-out group-hover:text-brand-dark"><span class="w-full relative">BOOK A DEMO</span></span></a>

											<a href="<?php the_field('sign_in_button', 'options') ?>" class="text-center group relative inline-block border px-5 border-brand-dark rounded-md overflow-hidden "> <span class="block absolute left-0 inset-y-0 w-full origin-right scale-x-0 transition-transform duration-300 ease-in-out group-hover:scale-x-100 group-hover:origin-left bg-white"></span> <span class="flex items-center space-x-3 py-2 text-base text-brand-dark transition-colors duration-300 ease-in-out group-hover:text-brand-dark"><span class="w-full relative">SIGN IN</span></span></a>
										</div>
									</nav>
								<?php endif ?>
							<?php endif ?>
							<?php if (!($show_only_logo)): ?>
								<div class="absolute open-menu block lg:hidden">
									<svg viewBox="0 0 37 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="absolute top-[50%] right-0 z-10 w-[16.6vw] h-[6.4vw] transform translate-y-[-50%] stroke-current">
										<path class="menu-svg-path-open block" d="M0 1.421h36.386M0 23.421h36.386M10 12.421h26" stroke="#000000" fill="none"></path>

										<path class="menu-svg-path-close hidden" d="M1 .686l24 24M25 .686l-24 24" stroke="#000000" fill="none"></path>
									</svg>
								</div>
							<?php endif ?>
						<?php endif ?>
					</header>


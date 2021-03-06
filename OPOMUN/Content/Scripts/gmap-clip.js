﻿function initMap() {
	var CLIPLoc = {
		lat: 41.173413,
		lng: -8.671141
	}
	var map = new google.maps.Map(document.getElementById('map'), {
		center: CLIPLoc,
		zoom: 15,
		disableDefaultUI: true,
		streetViewControl: false,
		zoomControl: false,
		scaleControl: false,
		scrollwheel: false,
		draggable: false,
		disableDoubleClickZoom: true,
		styles: [{
			"elementType": "geometry",
			"stylers": [{
				"color": "#f5f5f5"
			}]
		}, {
			"elementType": "labels.icon",
			"stylers": [{
				"visibility": "off"
			}]
		}, {
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#616161"
			}]
		}, {
			"elementType": "labels.text.stroke",
			"stylers": [{
				"color": "#f5f5f5"
			}]
		}, {
			"featureType": "administrative.land_parcel",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#bdbdbd"
			}]
		}, {
			"featureType": "poi",
			"elementType": "geometry",
			"stylers": [{
				"color": "#eeeeee"
			}]
		}, {
			"featureType": "poi",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#757575"
			}]
		}, {
			"featureType": "poi.business",
			"stylers": [{
				"visibility": "off"
			}]
		}, {
			"featureType": "poi.park",
			"elementType": "geometry",
			"stylers": [{
				"color": "#e5e5e5"
			}]
		}, {
			"featureType": "poi.park",
			"elementType": "labels.text",
			"stylers": [{
				"visibility": "off"
			}]
		}, {
			"featureType": "poi.park",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#9e9e9e"
			}]
		}, {
			"featureType": "road",
			"elementType": "geometry",
			"stylers": [{
				"color": "#ffffff"
			}]
		}, {
			"featureType": "road.arterial",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#757575"
			}]
		}, {
			"featureType": "road.highway",
			"elementType": "geometry",
			"stylers": [{
				"color": "#dadada"
			}]
		}, {
			"featureType": "road.highway",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#616161"
			}]
		}, {
			"featureType": "road.local",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#9e9e9e"
			}]
		}, {
			"featureType": "transit.line",
			"elementType": "geometry",
			"stylers": [{
				"color": "#e5e5e5"
			}]
		}, {
			"featureType": "transit.station",
			"elementType": "geometry",
			"stylers": [{
				"color": "#eeeeee"
			}]
		}, {
			"featureType": "water",
			"elementType": "geometry",
			"stylers": [{
				"color": "#c9c9c9"
			}]
		}, {
			"featureType": "water",
			"elementType": "labels.text.fill",
			"stylers": [{
				"color": "#9e9e9e"
			}]
		}]
	});
	var pinColor = "3FA9F5";
	var pinImage = new google.maps.MarkerImage(
		"http://chart.apis.google.com/chart?chst=d_map_pin_letter&chld=%E2%80%A2|" +
		pinColor, new google.maps.Size(21, 34), new google.maps.Point(0, 0), new google
		.maps.Point(10, 34));
	var pinShadow = new google.maps.MarkerImage(
		"http://chart.apis.google.com/chart?chst=d_map_pin_shadow", new google.maps
		.Size(40, 37), new google.maps.Point(0, 0), new google.maps.Point(12, 35));
	var marker = new google.maps.Marker({
		position: CLIPLoc,
		map: map,
		icon: pinImage,
		shadow: pinShadow,
		title: 'CLIP',
	});
}
using UnityEngine;
using System.Collections;
using U3DXT.iOS.Native.MapKit;
using U3DXT.iOS.Native.CoreLocation;

public class Annotation : MKAnnotation {

	private CLLocationCoordinate2D _coord;
	private string _title;
	private string _subtitle;
	
	public Annotation(CLLocationCoordinate2D coord, string title, string subtitle) {
		_coord = coord;
		_title = title;
		_subtitle = subtitle;
	}
	
	public override CLLocationCoordinate2D coordinate {
		get { return _coord; }
	}
	
	public override string title {
		get { return _title; }
	}

	public override string subtitle {
		get { return _subtitle; }
	}
}

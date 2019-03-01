/**
 * @license Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	//config.language = 'es';
	//config.uiColor = '#F7B42C';
	config.uiColor = '#c0c0c0';
	//config.uiColor = '#FFFFFF';
	config.height = 300;
	config.toolbarCanCollapse = true;
	config.toolbarGroups = [
		{ name: 'document', groups: [ 'mode', 'document', 'doctools' ] },
		{ name: 'clipboard', groups: [ 'clipboard', 'undo' ] },
		{ name: 'editing', groups: [ 'find', 'selection', 'spellchecker', 'editing' ] },
		{ name: 'forms', groups: [ 'forms' ] },
		'/',
		{ name: 'basicstyles', groups: [ 'basicstyles', 'cleanup' ] },
		{ name: 'paragraph', groups: [ 'list', 'indent', 'blocks', 'align', 'bidi', 'paragraph' ] },
		{ name: 'links', groups: [ 'links' ] },
		{ name: 'insert', groups: [ 'insert' ] },
		'/',
		{ name: 'styles', groups: [ 'styles' ] },
		{ name: 'colors', groups: [ 'colors' ] },
		{ name: 'tools', groups: [ 'tools' ] },
		{ name: 'others', groups: [ 'others' ] },
		{ name: 'about', groups: [ 'about' ] }
	];

	config.removeButtons = 'Source,Flash';
	//config.specialChars = [ '&quot;', '&rsquo;', [ '&custom;', 'Custom label' ] ];
    config.specialChars = config.specialChars.concat( [ '&quot;', [ '&rsquo;', 'Custom label' ] ] );
	config.specialChars = config.specialChars.concat( [ ['&radic;','radic'],['&#8731;','radic'],['&#8732;','radic'],['&infin;','radic'],[ '&alpha;', 'alpha' ],
      [ '&beta;', 'beta' ],
      [ '&gamma;', 'gamma' ],
      [ '&delta;', 'delta' ],
      [ '&epsilon;', 'epsilon' ],
      [ '&zeta;', 'zeta' ],
      [ '&eta;', 'eta' ],
      [ '&theta;', 'theta' ],
      [ '&iota;', 'iota' ],
      [ '&kappa;', 'kappa' ],
      [ '&lambda;', 'lambda' ],
      [ '&mu;', 'mu' ],
      [ '&nu;', 'nu' ],
      [ '&xi;', 'xi' ],
      [ '&omicron;', 'omicron' ],
      [ '&pi;', 'pi' ],
      [ '&rho;', 'rho' ],
      [ '&sigma;', 'sigma' ],
      [ '&tau;', 'tau' ],
      [ '&upsilon;', 'upsilon' ],
      [ '&phi;', 'phi' ],
      [ '&chi;', 'chi' ],
      [ '&psi;', 'psi' ],
      [ '&omega;', 'omega' ] ] );
};

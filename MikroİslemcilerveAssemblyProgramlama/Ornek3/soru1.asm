LIST	P=16F84
INCLUDE	"P16F84.INC"

BASLA
	CLRF	PORTB
	BSF	STATUS,5
	CLRF	TRISB
	MOVLW	h'FF'
	MOVWF	TRISA
	BCF	STATUS,5

START
	MOVF	PORTA,W
	MOVWF	PORTB
	GOTO	START
END
	LIST	P=16F84
	INCLUDE	"P16F84.INC"
SAYAC1	EQU	H'0C'
SAYAC2	EQU	H'0D'
	BSF	STATUS,5
	CLRF	PORTB
	BSF	TRISA,0
	BCF	STATUS,5
	CLRF	PORTB

TEST
	BTFSC	PORTA,0
	GOTO	TEST
	MOVLW	H'01'
	MOVWF	PORTB
SOL
	CALL	GECIKME
	RLF	PORTB,F
	BTFSS	PORTB,7
	GOTO	SOL
SAG
	CALL	GECIKME
	RRF	PORTB,F
	BTFSS	PORTB,0
	GOTO	SAG
	GOTO	SOL

GECIKME
	MOVLW	D'255'
	MOVWF	SAYAC1
YUKLE1
	MOVLW	D'255'
	MOVWF	SAYAC2
AZALT
	DECFSZ	SAYAC2,F
	GOTO	AZALT	
	DECFSZ	SAYAC1,F
	GOTO	YUKLE1
	RETURN
	END
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirEnemy : Enemy
{
    // Start is called before the first frame update
   
    
    /*
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    */

    // Update is called once per frame
    void Update()
    {
        EscolheAcao();
        if(coolDown == 2f){
        	shootLock = false;
        }
        else{
        	coolDown = coolDown - 0.1f;
        	if(coolDown < 0){
        		coolDown = 2f;
        	}
        }
        
        if(acaoescolhida == 1 && vendo){
        	DirectTackle();
        }
        if(acaoescolhida == 2 && attackMode && !shootLock){
        	Shoot();
        	shootLock = true;
        	coolDown = coolDown - 0.1f;
        }
        /*
        else{
        	if(acaoescolhida == 1){
        		acaoescolhida == 
        	}
        }
        */
    }

    void FixedUpdate(){
    	ModeUpdate(); 
    }

    // tentando fazer ele colidir com a TRAIL!
    void OnTriggerEnter2D(Collider2D other){
    	if(other.name.Equals("Player")){
    		// ativa efeito (vi o jogador)
    		SwitchMode();
    		Debug.Log("TO TE VENDO FILHO DA PUTA");
    	}	
    }

    void OnTriggerStay2D(Collider2D other){
    	if(other.name.Equals("Player")){
    		//vendo = true;
    		StayMode();
    	}
    }

    void OnTriggerExit2D(Collider2D other){
    	if(other.name.Equals("Player")){
    		vendo = false;
    		
    	}
    }

    // move (um movimento padrão que ele fica fazendo enquanto não ataca) (ele eventualmente RANDOM pode fazer esse movimento também mesmo em modo de ataque)
}

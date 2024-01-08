"use client"
// import { useState } from "react";
import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";
// import { motion } from 'framer-motion';
// import ToggleButton from "./ToggleButton";
import {supabase} from '@/components/SupabaseClient'
import { motion } from 'framer-motion';
import { useState, useEffect } from "react";



interface MenuProps {
  menu: {
    menu_id: any;
  };
  userId: {
    userId: any;
  };
}


  // const handleToggle = (isChecked: boolean) => {
  //   console.log('Toggle state:', isChecked);
  //   // Add your toggle logic here
  // };

export default function ParticipateDay({ menu, userId }: MenuProps) {
  // const cookieStore = cookies();
  // const supabase = createClient(cookieStore);
//   if(supabase){
// const { data: dishData, error: dishError } = await supabase.from("menu_user").select().eq("user_id", userId.userId);
//       console.log(dishData)
//     }
const handleAccept = async () => {
    try {
      if (supabase) {
        const { data, error } = await supabase.from("menu_user").insert([
          {
            menu_id: menu.menu_id, user_id: userId.userId
          },
        ]);

        if (error) throw error;
        // console.log("Data submitted successfully", data);
      } else {
        console.error("Supabase client is null");
      }
    } catch (error) {
      console.error("Error submitting data", error);
    }
  };

  const handleDeny = async () => {
    try {
      if (supabase) {
        const { error } = await supabase.from("menu_user").delete().eq('menu_id', menu.menu_id).eq('user_id', userId.userId);
        if (error) throw error;
        // console.log("Data deleted successfully");
      } else {
        console.error("Supabase client is null");
      }
    } catch (error) {
      console.error("Error deleting data", error);
    }
  };
 
  const [toggle, setToggle] = useState<boolean>(false);

  useEffect(() => {
    const checkRowExists = async () => {
      try {
        if (supabase) {
          const { data, error } = await supabase
            .from("menu_user")
            .select()
            .eq("menu_id", menu.menu_id)
            .eq("user_id", userId.userId);

          if (error) throw error;

          // If there is a row, set toggle to true; otherwise, set it to false
          setToggle(data.length > 0);
        } else {
          console.error("Supabase client is null");
        }
      } catch (error) {
        console.error("Error checking row existence", error);
      }
    };

    // Call the checkRowExists function when the component mounts
    checkRowExists();
  }, [menu.menu_id, userId.userId]);
  
  const handleToggle = async () => {
    setToggle(!toggle);

    if (!toggle) {
      try {
        await handleAccept()
      } catch (error) {
        console.error('Error inserting row:', error);
      }
    }else {
      try {
      await handleDeny()
    } catch (error) {
      console.error('Error deleting row:', error);
    }
    }
  };

  return (
    <div>
      {/* <ToggleButton onToggle={handleToggle}/> */}
      {/* {menu.menu_id && userId.userId = } */}
      {/*<button id="button" onClick={handleDeny}>deltag ikke</button> */}
      {/* <button id="button" className="mr-5" onClick={handleAccept}>deltag</button> */}
      <div className="flex flex-row cursor-pointer " onClick={handleToggle}>
        <p className="mr-3">Deltag</p>
      <div
        className={`flex h-6 w-12 cursor-pointer rounded-full ${toggle ? "justify-end bg-lime-400 ": "justify-start bg-zinc-400"} p-[2px]`}
      >
        <motion.div
          className={`h-5 w-5 rounded-full ${toggle ? "bg-lime-600" : "bg-zinc-700"}`}
          layout
          transition={{ type: "spring", stiffness: 700, damping: 30 }}
        />
      </div>
    </div>
    </div>
    // <div className="flex flex-row cursor-pointer " onClick={handleToggle}>
    //   <div
    //     className={`flex h-6 w-12 cursor-pointer rounded-full ${toggle ? "justify-end bg-lime-400 ": "justify-start bg-zinc-400"} p-[2px]`}
    //   >
    //     <motion.div
    //       className={`h-5 w-5 rounded-full ${toggle ? "bg-lime-600" : "bg-zinc-700"}`}
    //       layout
    //       transition={{ type: "spring", stiffness: 700, damping: 30 }}
    //     />
    //   </div>
    // </div>
  );
}
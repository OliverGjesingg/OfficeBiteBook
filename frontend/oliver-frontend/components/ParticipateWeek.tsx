"use client"

// import { getSupabaseClient } from "./SupabaseUtils";

import { useState } from "react";
import { motion } from 'framer-motion';

interface MenuProps{
  menu: {
    menu_id: any;
  }
}
// interface MenuProps {
//   menu: {
//     menu_id: any;
//   };
// }
// { menu }: MenuProps
export default function ParticipateWeek({menus}: MenuProps) {
  // const supabase = getSupabaseClient();

  console.log(menus)
  const [toggle, setToggle] = useState<boolean>(false);

  const handleToggle = async () => {
    setToggle(!toggle);

    // if (!toggle) {
    //   try {
    //     const { data, error } = await supabase
    //       .from('menu_user') // Replace 'your_table_name' with your actual table name
    //       .insert([{ menu_id: menu.menu_id, menu_user_id: "12345678", user_id:"528c90b2-0955-4cec-8ed1-d588519348c2" }]);
        
    //     if (error) {
    //       console.error('Error inserting row:', error);
    //     } else {
    //       console.log('Row inserted successfully:', data);
    //     }
    //   } catch (error) {
    //     console.error('Error inserting row:', error);
    //   }
    // }
  };

  return (
    <div className="flex flex-row cursor-pointer " onClick={handleToggle}>
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
  );
}
import { createClient } from '@/utils/supabase/server'
import Link from 'next/link'
import { cookies } from 'next/headers'
import { redirect } from 'next/navigation'


export default async function UserEdit() {
  const cookieStore = cookies()
  const supabase = createClient(cookieStore)

  


  //this gets the user from authentication
  const {
    data: { user },
  } = await supabase.auth.getUser();
  
  //get the userid
  const userId = user?.id;

  //gets the user in the table
  const { data: users } = await supabase.from("users").select().eq('user_id', userId).single();

  //get the location from the user's location_id
  // const { data: location } = await supabase.from("location").select().eq('location_id', users.location_id).single();

  // var NameElement = document.getElementById("Name");
  // console.log(NameElement)
  // var Name = NameElement instanceof HTMLInputElement ? NameElement.value : undefined;
  
  

  // const UpdateUser = async (formData: FormData) => {
  //   const Name = formData.get("Name") as string;

  //   console.log(Name)
  //   const {error } = await supabase.from('users').update({ user_name: Name }).eq('user_id', userId);
  //   if(error){
  //     error
  //   }

  //   return redirect('/')

  // }
  const { data: userImage } = await supabase
  .storage
  .from('user_images')
  .getPublicUrl(users?.user_image)
//  action={UpdateUser}

// const asdasdfa = document.getElementById("Name")
  return user ? (
    <div className='flex flex-col mt-20'>
      <form action={updateUser}>
        <label>Navn:</label>
        <br/>
        <input id="Name" name="name" defaultValue={users?.user_name}  className="rounded-md px-4 py-2 bg-inherit border mb-6 border-black"/>
        <br/>
        <label>TLF:</label>
        <br/>
        <input name="phone" defaultValue={users?.user_phone} className="rounded-md px-4 py-2 bg-inherit border mb-6 border-black"/>
        <br/>
        <label>Fødselsdag:</label>
        <br/>
        <input name="birthday" type="date" defaultValue={users?.user_birthday} className="rounded-md px-4 py-2 bg-inherit border mb-6 border-black"/>
        <br/>
        <label>Email:</label>
        <br/>
        <input name="email" defaultValue={users?.user_email}  className="rounded-md px-4 py-2 bg-inherit border mb-6 border-black"/>
        <br/>
        <label>Profil billede:</label>
        <input name="image" type="file"/>
        <img src={userImage?.publicUrl} className="w-50"/>
        {/* <p>{userId}</p>
        <p>{users?.user_id}</p> */}

        {/*<br/>
        <p className='mb-0.7'>{location.location_name}</p> */}
        <br/>
        
        <button className="bg-orange-500 rounded-md px-4 py-2 text-foreground mb-2 mt-5">
          Gem ændringer
        </button>
      </form>
    </div>
  ) : (
    <Link
      href="/login"
      className="py-2 px-3 flex rounded-md no-underline bg-btn-background hover:bg-btn-background-hover"
    >
      Login
    </Link>
  )
}



const updateUser = async (formData: FormData) => {
  'use server'

  const cookieStore = cookies()
  const supabase = createClient(cookieStore)

      //this gets the user from authentication
      const {
        data: { user },
    } = await supabase.auth.getUser();
    
    //get the userid
    const userId = user?.id;

  const Name = formData.get('name') as string
  const Img = formData.get('image') as File
  // const Birthday = formData.get('birthday') as Date
  // const Birthday = formData.get('birthday') as date
  const Email = formData.get('email') as string
  const Phone = formData.get('phone') as string

  const birthdayString = formData.get('birthday') as string;
  const birthdayDate = new Date(birthdayString);

  // Now birthdayDate is a Date object
  
  const { error} = await supabase.from('users').update({ user_name: Name, user_phone: Phone, user_email: Email, user_birthday: birthdayDate, user_image: Img.name}).eq('user_id', userId);
  // const { error } = await supabase.auth.signInWithPassword({
  //   email,
  //   password,
  // })

  if (error) {
    console.log(error)
  }

  return redirect('')
}